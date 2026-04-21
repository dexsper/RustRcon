using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Automatically upload procedurally generated maps so that players download them (faster) instead of re-generating them</summary>
/// <remarks>Full RCON name: <c>server.autouploadmap</c></remarks>
public sealed class ServerAutouploadmapCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.autouploadmap";

    /// <summary>Reads the current value of <c>server.autouploadmap</c>.</summary>
    public static ServerAutouploadmapCommand CreateGet()
    {
        var cmd = CreatePackage<ServerAutouploadmapCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.autouploadmap</c> to <paramref name="value"/>.</summary>
    public static ServerAutouploadmapCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerAutouploadmapCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
