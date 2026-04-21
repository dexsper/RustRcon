using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If greater than zero, overrides the drone's vertical movement speed</summary>
/// <remarks>Full RCON name: <c>drone.altitudespeedoverride</c></remarks>
public sealed class DroneAltitudespeedoverrideCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "drone.altitudespeedoverride";

    /// <summary>Reads the current value of <c>drone.altitudespeedoverride</c>.</summary>
    public static DroneAltitudespeedoverrideCommand CreateGet()
    {
        var cmd = CreatePackage<DroneAltitudespeedoverrideCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>drone.altitudespeedoverride</c> to <paramref name="value"/>.</summary>
    public static DroneAltitudespeedoverrideCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DroneAltitudespeedoverrideCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
