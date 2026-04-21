using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Controls who is subject to the idle kick: 0 = nobody, 1 = non-admin players only, 2 = all players including admins</summary>
/// <remarks>Full RCON name: <c>server.idlekickmode</c></remarks>
public sealed class ServerIdlekickmodeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.idlekickmode";

    /// <summary>Reads the current value of <c>server.idlekickmode</c>.</summary>
    public static ServerIdlekickmodeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerIdlekickmodeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.idlekickmode</c> to <paramref name="value"/>.</summary>
    public static ServerIdlekickmodeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerIdlekickmodeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
