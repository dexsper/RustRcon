using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Additional offset applied to the world boundary force zone, extending the buffer zone inside the boundary before the force ramps up</summary>
/// <remarks>Full RCON name: <c>vehicle.world_boundary_force_offset</c></remarks>
public sealed class VehicleWorldBoundaryForceOffsetCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vehicle.world_boundary_force_offset";

    /// <summary>Reads the current value of <c>vehicle.world_boundary_force_offset</c>.</summary>
    public static VehicleWorldBoundaryForceOffsetCommand CreateGet()
    {
        var cmd = CreatePackage<VehicleWorldBoundaryForceOffsetCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vehicle.world_boundary_force_offset</c> to <paramref name="value"/>.</summary>
    public static VehicleWorldBoundaryForceOffsetCommand CreateSet(float value)
    {
        var cmd = CreatePackage<VehicleWorldBoundaryForceOffsetCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
