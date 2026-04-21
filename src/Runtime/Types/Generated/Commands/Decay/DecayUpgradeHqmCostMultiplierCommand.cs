using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Can players upgrade building blocks to hqm</summary>
/// <remarks>Full RCON name: <c>decay.upgrade_hqm_cost_multiplier</c></remarks>
public sealed class DecayUpgradeHqmCostMultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.upgrade_hqm_cost_multiplier";

    /// <summary>Reads the current value of <c>decay.upgrade_hqm_cost_multiplier</c>.</summary>
    public static DecayUpgradeHqmCostMultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<DecayUpgradeHqmCostMultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.upgrade_hqm_cost_multiplier</c> to <paramref name="value"/>.</summary>
    public static DecayUpgradeHqmCostMultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayUpgradeHqmCostMultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
