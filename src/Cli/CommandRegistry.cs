using System.Reflection;
using System.Xml.Linq;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Cli;

internal sealed class CommandMeta
{
    public required Type Type { get; init; }
    public required string FullName { get; init; }
    public required IReadOnlyList<ParameterInfo> Parameters { get; init; }
    public required string Description { get; init; }

    public string ShortName => FullName[(FullName.LastIndexOf('.') + 1)..];
}

internal sealed class CommandRegistry
{
    private readonly Dictionary<string, CommandMeta> _byFullName;
    private readonly Dictionary<string, List<CommandMeta>> _byShortName;

    public IReadOnlyList<CommandMeta> All { get; }

    public CommandRegistry()
    {
        var xmlDocs = LoadXmlDocs();
        var commands = typeof(BaseCommand).Assembly
            .GetTypes()
            .Where(t => t is { IsAbstract: false } && t.IsSubclassOf(typeof(BaseCommand)))
            .Select(t => BuildMeta(t, xmlDocs))
            .OfType<CommandMeta>()
            .OrderBy(m => m.FullName)
            .ToList();

        All = commands;

        _byFullName = commands.ToDictionary(c => c.FullName, StringComparer.OrdinalIgnoreCase);
        _byShortName = commands
            .GroupBy(c => c.ShortName, StringComparer.OrdinalIgnoreCase)
            .ToDictionary(g => g.Key, g => g.ToList(), StringComparer.OrdinalIgnoreCase);
    }

    /// <summary>
    ///     Resolves <paramref name="name"/> to a command:
    ///     <list type="number">
    ///         <item>Exact full-name match (e.g. <c>global.serverinfo</c>).</item>
    ///         <item>Unique short-name match (e.g. <c>serverinfo</c> → <c>global.serverinfo</c>).</item>
    ///     </list>
    ///     Returns <c>(null, ambiguous)</c> when the short name matches multiple commands.
    /// </summary>
    public (CommandMeta? Meta, IReadOnlyList<CommandMeta> Ambiguous) Resolve(string name)
    {
        if (_byFullName.TryGetValue(name, out var exact))
            return (exact, []);

        if (_byShortName.TryGetValue(name, out var candidates))
            return candidates.Count == 1 ? (candidates[0], []) : (null, candidates);

        return (null, []);
    }

    /// <summary>Returns commands whose full name starts with <paramref name="prefix"/>.</summary>
    public IEnumerable<CommandMeta> Search(string prefix)
    {
        return All.Where(c => c.FullName.StartsWith(prefix, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>Returns commands whose short name starts with <paramref name="prefix"/>.</summary>
    public IEnumerable<CommandMeta> SearchByShortName(string prefix)
    {
        return All.Where(c => c.ShortName.StartsWith(prefix, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>Searches both full name and description for <paramref name="query"/>.</summary>
    public IEnumerable<CommandMeta> Find(string query)
    {
        if (string.IsNullOrWhiteSpace(query))
            return All;

        return All.Where(c =>
            c.FullName.Contains(query, StringComparison.OrdinalIgnoreCase) ||
            c.Description.Contains(query, StringComparison.OrdinalIgnoreCase));
    }

    private static CommandMeta? BuildMeta(Type type, IReadOnlyDictionary<string, string> xmlDocs)
    {
        var field = type.GetField("CommandFullName", BindingFlags.Public | BindingFlags.Static);
        if (field?.GetValue(null) is not string fullName)
            return null;

        var createMethod = type.GetMethod("Create", BindingFlags.Public | BindingFlags.Static);
        xmlDocs.TryGetValue(type.FullName ?? string.Empty, out var description);

        return new CommandMeta
        {
            Type = type,
            FullName = fullName,
            Parameters = createMethod?.GetParameters() ?? Array.Empty<ParameterInfo>(),
            Description = description ?? string.Empty
        };
    }

    private static Dictionary<string, string> LoadXmlDocs()
    {
        var assembly = typeof(BaseCommand).Assembly;
        var xmlPath = Path.ChangeExtension(assembly.Location, ".xml");

        if (!File.Exists(xmlPath))
            xmlPath = Path.Combine(AppContext.BaseDirectory, Path.GetFileName(xmlPath));

        if (!File.Exists(xmlPath))
            return new Dictionary<string, string>();

        try
        {
            return XDocument.Load(xmlPath)
                .Descendants("member")
                .Where(m => m.Attribute("name")?.Value.StartsWith("T:", StringComparison.Ordinal) == true)
                .ToDictionary(
                    m => m.Attribute("name")!.Value[2..],
                    m => m.Element("summary")?.Value.Trim() ?? string.Empty,
                    StringComparer.Ordinal
                );
        }
        catch
        {
            return new Dictionary<string, string>();
        }
    }
}