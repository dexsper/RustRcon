using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.melee_backtracking</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.melee_backtracking</c></remarks>
public sealed class AntihackMeleeBacktrackingCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.melee_backtracking";

    /// <summary>Reads the current value of <c>antihack.melee_backtracking</c>.</summary>
    public static AntihackMeleeBacktrackingCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackMeleeBacktrackingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.melee_backtracking</c> to <paramref name="value"/>.</summary>
    public static AntihackMeleeBacktrackingCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackMeleeBacktrackingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
