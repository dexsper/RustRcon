using RustRcon.Pooling;
using RustRcon.Types.Commands.Base;
using RustRcon.Types.Oxide;
using RustRcon.Types.Response.Server;

namespace RustRcon.Types.Commands.Oxide;

/// <summary>
///     Retrieves the list of installed Oxide plugins (<c>o.plugins</c>).
///     Only available when Oxide/uMod is loaded on the server.
/// </summary>
public sealed class GetPlugins : BaseCommand
{
    /// <summary>The parsed plugin list, available after the command completes.</summary>
    public PoolableList<Plugin>? Result { get; private set; }

    /// <summary>Creates a new <see cref="GetPlugins"/> command.</summary>
    public static GetPlugins Create()
    {
        var command = CreatePackage<GetPlugins>();
        command.Content = "o.plugins";
        return command;
    }

    /// <inheritdoc/>
    public override void Complete(ServerResponse response)
    {
        base.Complete(response);

        if (string.IsNullOrEmpty(response.Content) || !response.Content.StartsWith("Listing"))
            return;

        var list = RustRconPool.Get<PoolableList<Plugin>>();

        try
        {
            var lines = response.Content.AsSpan().Trim().Split("\n");
            var enumerator = lines.GetEnumerator();
            enumerator.MoveNext(); // skip header line

            while (enumerator.MoveNext())
            {
                var line = enumerator.Current.AsSpan().Trim();
                if (line.IsEmpty) continue;

                var plugin = ParsePlugin(line);
                if (plugin.HasValue)
                    list.Add(plugin.Value);
            }

            Result = list;
        }
        catch
        {
            list.Dispose();
        }
    }

    private static Plugin? ParsePlugin(ReadOnlySpan<char> line)
    {
        try
        {
            int titleStart = line.IndexOf('"') + 1;
            if (titleStart <= 0) return null;
            int titleEnd = line[titleStart..].IndexOf('"') + titleStart;

            int versionStart = line[titleEnd..].IndexOf('(') + titleEnd + 1;
            int versionEnd = line[versionStart..].IndexOf(')') + versionStart;

            int byIdx = line[versionEnd..].IndexOf("by ");
            if (byIdx < 0) return null;
            int authorStart = versionEnd + byIdx + 3;
            int authorEnd = line[authorStart..].IndexOf('(') + authorStart - 1;

            int timeStart = line[authorEnd..].IndexOf('(') + authorEnd + 1;
            int timeEnd = line[timeStart..].IndexOf('s') + timeStart + 1;

            int memStart = line[timeEnd..].IndexOf('/') + timeEnd + 2;
            int memEnd = line[memStart..].IndexOf(' ') + memStart + 1;

            int fileStart = line[memEnd..].IndexOf("- ") + memEnd + 2;

            return new Plugin(
                filename: line[fileStart..].Trim().ToString(),
                name: line[titleStart..titleEnd].ToString(),
                version: line[versionStart..versionEnd].ToString(),
                author: line[authorStart..authorEnd].Trim().ToString(),
                totalHookTime: line[timeStart..timeEnd].ToString(),
                totalHookMemory: line[memStart..memEnd].Trim().ToString()
            );
        }
        catch
        {
            return null;
        }
    }

    protected override void EnterPool()
    {
        base.EnterPool();
        Result?.Dispose();
        Result = null;
    }
}
