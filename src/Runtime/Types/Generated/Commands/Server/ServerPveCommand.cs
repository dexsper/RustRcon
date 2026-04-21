using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Enables PvE mode — players cannot damage other players; they can still be killed by NPCs and the environment</summary>
/// <remarks>Full RCON name: <c>server.pve</c></remarks>
public sealed class ServerPveCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.pve";

    /// <summary>Reads the current value of <c>server.pve</c>.</summary>
    public static ServerPveCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPveCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.pve</c> to <paramref name="value"/>.</summary>
    public static ServerPveCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerPveCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
