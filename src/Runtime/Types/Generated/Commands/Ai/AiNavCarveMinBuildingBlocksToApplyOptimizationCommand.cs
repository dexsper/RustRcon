using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The minimum number of building blocks a building needs to consist of for this optimization to be applied. (default: 25)</summary>
/// <remarks>Full RCON name: <c>ai.nav_carve_min_building_blocks_to_apply_optimization</c></remarks>
public sealed class AiNavCarveMinBuildingBlocksToApplyOptimizationCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.nav_carve_min_building_blocks_to_apply_optimization";

    /// <summary>Reads the current value of <c>ai.nav_carve_min_building_blocks_to_apply_optimization</c>.</summary>
    public static AiNavCarveMinBuildingBlocksToApplyOptimizationCommand CreateGet()
    {
        var cmd = CreatePackage<AiNavCarveMinBuildingBlocksToApplyOptimizationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.nav_carve_min_building_blocks_to_apply_optimization</c> to <paramref name="value"/>.</summary>
    public static AiNavCarveMinBuildingBlocksToApplyOptimizationCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AiNavCarveMinBuildingBlocksToApplyOptimizationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
