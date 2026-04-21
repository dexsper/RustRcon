using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Should hte player see their direction on the map</summary>
/// <remarks>Full RCON name: <c>server.hideplayermapdirection</c></remarks>
public sealed class ServerHideplayermapdirectionCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.hideplayermapdirection";

    /// <summary>Reads the current value of <c>server.hideplayermapdirection</c>.</summary>
    public static ServerHideplayermapdirectionCommand CreateGet()
    {
        var cmd = CreatePackage<ServerHideplayermapdirectionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.hideplayermapdirection</c> to <paramref name="value"/>.</summary>
    public static ServerHideplayermapdirectionCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerHideplayermapdirectionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
