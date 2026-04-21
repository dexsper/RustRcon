using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Distance in metres from a deep-sea portal boundary at which the repulsion force activates for vehicles</summary>
/// <remarks>Full RCON name: <c>vehicle.deepseaportal_boundary_force_start_distance</c></remarks>
public sealed class VehicleDeepseaportalBoundaryForceStartDistanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vehicle.deepseaportal_boundary_force_start_distance";

    /// <summary>Reads the current value of <c>vehicle.deepseaportal_boundary_force_start_distance</c>.</summary>
    public static VehicleDeepseaportalBoundaryForceStartDistanceCommand CreateGet()
    {
        var cmd = CreatePackage<VehicleDeepseaportalBoundaryForceStartDistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vehicle.deepseaportal_boundary_force_start_distance</c> to <paramref name="value"/>.</summary>
    public static VehicleDeepseaportalBoundaryForceStartDistanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<VehicleDeepseaportalBoundaryForceStartDistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
