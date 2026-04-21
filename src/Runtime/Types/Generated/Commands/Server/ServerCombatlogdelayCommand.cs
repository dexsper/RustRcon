using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Seconds of delay before a combat event appears in the player's own combat log, preventing real-time tracking during a fight</summary>
/// <remarks>Full RCON name: <c>server.combatlogdelay</c></remarks>
public sealed class ServerCombatlogdelayCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.combatlogdelay";

    /// <summary>Reads the current value of <c>server.combatlogdelay</c>.</summary>
    public static ServerCombatlogdelayCommand CreateGet()
    {
        var cmd = CreatePackage<ServerCombatlogdelayCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.combatlogdelay</c> to <paramref name="value"/>.</summary>
    public static ServerCombatlogdelayCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerCombatlogdelayCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
