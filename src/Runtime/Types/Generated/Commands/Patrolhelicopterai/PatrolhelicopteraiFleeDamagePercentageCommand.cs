using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Fraction of maximum health at which the patrol helicopter will break off its attack and flee; default 0.35 (35%)</summary>
/// <remarks>Full RCON name: <c>patrolhelicopterai.flee_damage_percentage</c></remarks>
public sealed class PatrolhelicopteraiFleeDamagePercentageCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "patrolhelicopterai.flee_damage_percentage";

    /// <summary>Reads the current value of <c>patrolhelicopterai.flee_damage_percentage</c>.</summary>
    public static PatrolhelicopteraiFleeDamagePercentageCommand CreateGet()
    {
        var cmd = CreatePackage<PatrolhelicopteraiFleeDamagePercentageCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>patrolhelicopterai.flee_damage_percentage</c> to <paramref name="value"/>.</summary>
    public static PatrolhelicopteraiFleeDamagePercentageCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PatrolhelicopteraiFleeDamagePercentageCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
