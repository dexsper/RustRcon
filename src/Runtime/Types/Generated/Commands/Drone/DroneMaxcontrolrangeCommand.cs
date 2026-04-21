using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How far drones can be flown away from the controlling computer station</summary>
/// <remarks>Full RCON name: <c>drone.maxcontrolrange</c></remarks>
public sealed class DroneMaxcontrolrangeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "drone.maxcontrolrange";

    /// <summary>Reads the current value of <c>drone.maxcontrolrange</c>.</summary>
    public static DroneMaxcontrolrangeCommand CreateGet()
    {
        var cmd = CreatePackage<DroneMaxcontrolrangeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>drone.maxcontrolrange</c> to <paramref name="value"/>.</summary>
    public static DroneMaxcontrolrangeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DroneMaxcontrolrangeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
