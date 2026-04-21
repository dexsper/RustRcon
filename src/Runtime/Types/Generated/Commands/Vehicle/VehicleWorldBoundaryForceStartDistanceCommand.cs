using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Distance in metres from the world boundary at which a repulsion force starts pushing vehicles back inward; prevents vehicles from leaving the playable area</summary>
/// <remarks>Full RCON name: <c>vehicle.world_boundary_force_start_distance</c></remarks>
public sealed class VehicleWorldBoundaryForceStartDistanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vehicle.world_boundary_force_start_distance";

    /// <summary>Reads the current value of <c>vehicle.world_boundary_force_start_distance</c>.</summary>
    public static VehicleWorldBoundaryForceStartDistanceCommand CreateGet()
    {
        var cmd = CreatePackage<VehicleWorldBoundaryForceStartDistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vehicle.world_boundary_force_start_distance</c> to <paramref name="value"/>.</summary>
    public static VehicleWorldBoundaryForceStartDistanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<VehicleWorldBoundaryForceStartDistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
