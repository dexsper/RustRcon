using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Should the player see their position on the map</summary>
/// <remarks>Full RCON name: <c>server.hideplayeronmap</c></remarks>
public sealed class ServerHideplayeronmapCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.hideplayeronmap";

    /// <summary>Reads the current value of <c>server.hideplayeronmap</c>.</summary>
    public static ServerHideplayeronmapCommand CreateGet()
    {
        var cmd = CreatePackage<ServerHideplayeronmapCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.hideplayeronmap</c> to <paramref name="value"/>.</summary>
    public static ServerHideplayeronmapCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerHideplayeronmapCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
