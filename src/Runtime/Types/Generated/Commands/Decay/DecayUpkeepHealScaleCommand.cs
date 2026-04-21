using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Scale at which objects heal when upkeep conditions are met, default of 1 is same rate at which they decay</summary>
/// <remarks>Full RCON name: <c>decay.upkeep_heal_scale</c></remarks>
public sealed class DecayUpkeepHealScaleCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.upkeep_heal_scale";

    /// <summary>Reads the current value of <c>decay.upkeep_heal_scale</c>.</summary>
    public static DecayUpkeepHealScaleCommand CreateGet()
    {
        var cmd = CreatePackage<DecayUpkeepHealScaleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.upkeep_heal_scale</c> to <paramref name="value"/>.</summary>
    public static DecayUpkeepHealScaleCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayUpkeepHealScaleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
