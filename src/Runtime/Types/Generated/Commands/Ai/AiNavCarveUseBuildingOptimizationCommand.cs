using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If nav_carve_use_building_optimization is true, we attempt to reduce the amount of navmesh carves for a building. (default: false)</summary>
/// <remarks>Full RCON name: <c>ai.nav_carve_use_building_optimization</c></remarks>
public sealed class AiNavCarveUseBuildingOptimizationCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.nav_carve_use_building_optimization";

    /// <summary>Reads the current value of <c>ai.nav_carve_use_building_optimization</c>.</summary>
    public static AiNavCarveUseBuildingOptimizationCommand CreateGet()
    {
        var cmd = CreatePackage<AiNavCarveUseBuildingOptimizationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.nav_carve_use_building_optimization</c> to <paramref name="value"/>.</summary>
    public static AiNavCarveUseBuildingOptimizationCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiNavCarveUseBuildingOptimizationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
