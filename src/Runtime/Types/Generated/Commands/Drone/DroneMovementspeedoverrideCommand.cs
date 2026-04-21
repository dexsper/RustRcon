using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If greater than zero, overrides the drone's planar movement speed</summary>
/// <remarks>Full RCON name: <c>drone.movementspeedoverride</c></remarks>
public sealed class DroneMovementspeedoverrideCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "drone.movementspeedoverride";

    /// <summary>Reads the current value of <c>drone.movementspeedoverride</c>.</summary>
    public static DroneMovementspeedoverrideCommand CreateGet()
    {
        var cmd = CreatePackage<DroneMovementspeedoverrideCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>drone.movementspeedoverride</c> to <paramref name="value"/>.</summary>
    public static DroneMovementspeedoverrideCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DroneMovementspeedoverrideCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
