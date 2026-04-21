using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, wheel colliders are disabled on vehicles that have gone to sleep in the physics engine, reducing CPU overhead for parked vehicles</summary>
/// <remarks>Full RCON name: <c>vehicle.disable_wheels_when_sleeping</c></remarks>
public sealed class VehicleDisableWheelsWhenSleepingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vehicle.disable_wheels_when_sleeping";

    /// <summary>Reads the current value of <c>vehicle.disable_wheels_when_sleeping</c>.</summary>
    public static VehicleDisableWheelsWhenSleepingCommand CreateGet()
    {
        var cmd = CreatePackage<VehicleDisableWheelsWhenSleepingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vehicle.disable_wheels_when_sleeping</c> to <paramref name="value"/>.</summary>
    public static VehicleDisableWheelsWhenSleepingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<VehicleDisableWheelsWhenSleepingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
