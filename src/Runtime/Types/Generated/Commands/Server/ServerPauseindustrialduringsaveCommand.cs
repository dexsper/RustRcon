using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Should industrial be paused during autosaves</summary>
/// <remarks>Full RCON name: <c>server.pauseindustrialduringsave</c></remarks>
public sealed class ServerPauseindustrialduringsaveCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.pauseindustrialduringsave";

    /// <summary>Reads the current value of <c>server.pauseindustrialduringsave</c>.</summary>
    public static ServerPauseindustrialduringsaveCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPauseindustrialduringsaveCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.pauseindustrialduringsave</c> to <paramref name="value"/>.</summary>
    public static ServerPauseindustrialduringsaveCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerPauseindustrialduringsaveCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
