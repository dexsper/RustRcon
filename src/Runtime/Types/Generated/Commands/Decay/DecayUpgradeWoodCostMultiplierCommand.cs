using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Can players upgrade building blocks to wood</summary>
/// <remarks>Full RCON name: <c>decay.upgrade_wood_cost_multiplier</c></remarks>
public sealed class DecayUpgradeWoodCostMultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.upgrade_wood_cost_multiplier";

    /// <summary>Reads the current value of <c>decay.upgrade_wood_cost_multiplier</c>.</summary>
    public static DecayUpgradeWoodCostMultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<DecayUpgradeWoodCostMultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.upgrade_wood_cost_multiplier</c> to <paramref name="value"/>.</summary>
    public static DecayUpgradeWoodCostMultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayUpgradeWoodCostMultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
