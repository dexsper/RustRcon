using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.TypeSystem;

namespace RustRcon.Generator.Decompile;

/// <summary>
///     Decompiles types from the Oxide.Rust managed DLL folder back to C# source
///     strings for Roslyn analysis.
///     <list type="bullet">
///       <item>All <c>ConVar.*</c> types are discovered and decompiled automatically from
///         <c>Assembly-CSharp.dll</c>.</item>
///       <item>Well-known non-ConVar types (e.g. <c>ConsoleGen</c>, <c>Chat</c>,
///         <c>ServerUsers</c>) are also decompiled from <c>Assembly-CSharp.dll</c>.</item>
///       <item>Cross-assembly types (e.g. <c>Facepunch.BuildInfo</c>) are located by
///         searching every <c>*.dll</c> in the managed directory.</item>
///     </list>
/// </summary>
public sealed class DllDecompiler : IDisposable
{
    /// <summary>
    ///     Non-ConVar global types to always decompile from <c>Assembly-CSharp.dll</c>.
    ///     Key = dictionary key; Value = FullTypeName candidates in priority order.
    /// </summary>
    private static readonly Dictionary<string, string[]> KnownPrimaryTypes =
        new(StringComparer.Ordinal)
        {
            ["ConsoleGen"]  = ["ConsoleGen"],
            ["ServerUsers"] = ["ServerUsers"],
            ["Chat"]        = ["Chat"],
            ["Output"]      = ["Facepunch.Output"],
        };

    /// <summary>
    ///     Types that may live in assemblies other than <c>Assembly-CSharp.dll</c>.
    ///     The decompiler will search every DLL in the managed folder.
    /// </summary>
    private static readonly Dictionary<string, string[]> CrossAssemblyTypes =
        new(StringComparer.Ordinal)
        {
            ["BuildInfo"] = ["Facepunch.BuildInfo", "BuildInfo"],
        };

    private readonly string _managedDir;

    private readonly Dictionary<string, (CSharpDecompiler D, IDecompilerTypeSystem TS)> _decompilerCache
        = new(StringComparer.OrdinalIgnoreCase);

    /// <param name="managedDir">Directory containing all extracted managed DLLs.</param>
    public DllDecompiler(string managedDir)
    {
        if (!Directory.Exists(managedDir))
            throw new DirectoryNotFoundException($"Managed DLL directory not found: {managedDir}");
        _managedDir = managedDir;
    }

    /// <summary>
    ///     Decompiles all needed types and returns a dictionary mapping simple key
    ///     names to C# source text.
    /// </summary>
    public Dictionary<string, string> DecompileAll(IProgress<string>? progress = null)
    {
        var result = new Dictionary<string, string>(StringComparer.Ordinal);

        var (primary, primaryTs) = GetOrCreate(PrimaryDllPath);

        foreach (var (key, candidates) in KnownPrimaryTypes)
        {
            progress?.Report($"Decompiling {key}…");
            foreach (var candidate in candidates)
            {
                var src = TryDecompile(primary, primaryTs, candidate);
                if (src is not null) { result[key] = src; break; }
            }
        }

        var conVarTypes = primaryTs.GetAllTypeDefinitions()
            .Where(t => t.Namespace == "ConVar")
            .ToList();

        progress?.Report($"Decompiling {conVarTypes.Count} ConVar types from Assembly-CSharp…");
        foreach (var typeDef in conVarTypes)
        {
            if (result.ContainsKey(typeDef.Name)) continue;
            try { result[typeDef.Name] = primary.DecompileTypeAsString(typeDef.FullTypeName); }
            catch { }
        }

        foreach (var (key, candidates) in CrossAssemblyTypes)
        {
            if (result.ContainsKey(key)) continue;
            progress?.Report($"Searching all DLLs for {key}…");
            var src = FindInAnyDll(candidates);
            if (src is not null) result[key] = src;
        }

        return result;
    }

    private string PrimaryDllPath =>
        Path.Combine(_managedDir, "Assembly-CSharp.dll");

    private IEnumerable<string> GetAllDllPaths() =>
        Directory.GetFiles(_managedDir, "*.dll");

    private string? FindInAnyDll(string[] candidates)
    {
        foreach (var dllPath in GetAllDllPaths())
        {
            try
            {
                var (d, ts) = GetOrCreate(dllPath);
                foreach (var candidate in candidates)
                {
                    var src = TryDecompile(d, ts, candidate);
                    if (src is not null) return src;
                }
            }
            catch { }
        }
        return null;
    }

    private (CSharpDecompiler D, IDecompilerTypeSystem TS) GetOrCreate(string dllPath)
    {
        if (_decompilerCache.TryGetValue(dllPath, out var cached))
            return cached;

        if (!File.Exists(dllPath))
            throw new FileNotFoundException($"DLL not found: {dllPath}", dllPath);

        var settings = new DecompilerSettings(LanguageVersion.CSharp10_0)
        {
            ThrowOnAssemblyResolveErrors = false,
            UsingDeclarations            = true,
            ShowXmlDocumentation         = false,
        };

        var d  = new CSharpDecompiler(dllPath, settings);
        var ts = d.TypeSystem;
        var entry = (d, ts);
        _decompilerCache[dllPath] = entry;
        return entry;
    }

    private static string? TryDecompile(
        CSharpDecompiler decompiler,
        IDecompilerTypeSystem typeSystem,
        string fullTypeName)
    {
        try
        {
            var typeDef = typeSystem.FindType(new FullTypeName(fullTypeName)).GetDefinition();
            if (typeDef is null) return null;
            return decompiler.DecompileTypeAsString(typeDef.FullTypeName);
        }
        catch { return null; }
    }

    public void Dispose()
    {
        _decompilerCache.Clear();
    }
}
