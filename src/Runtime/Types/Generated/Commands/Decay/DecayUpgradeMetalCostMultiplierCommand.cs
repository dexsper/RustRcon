using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Can players upgrade building blocks to metal</summary>
/// <remarks>Full RCON name: <c>decay.upgrade_metal_cost_multiplier</c></remarks>
public sealed class DecayUpgradeMetalCostMultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.upgrade_metal_cost_multiplier";

    /// <summary>Reads the current value of <c>decay.upgrade_metal_cost_multiplier</c>.</summary>
    public static DecayUpgradeMetalCostMultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<DecayUpgradeMetalCostMultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.upgrade_metal_cost_multiplier</c> to <paramref name="value"/>.</summary>
    public static DecayUpgradeMetalCostMultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayUpgradeMetalCostMultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
