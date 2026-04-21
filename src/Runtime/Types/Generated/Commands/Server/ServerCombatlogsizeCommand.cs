using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of recent combat events retained in each player's combat log, viewable with combatlog</summary>
/// <remarks>Full RCON name: <c>server.combatlogsize</c></remarks>
public sealed class ServerCombatlogsizeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.combatlogsize";

    /// <summary>Reads the current value of <c>server.combatlogsize</c>.</summary>
    public static ServerCombatlogsizeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerCombatlogsizeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.combatlogsize</c> to <paramref name="value"/>.</summary>
    public static ServerCombatlogsizeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerCombatlogsizeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
