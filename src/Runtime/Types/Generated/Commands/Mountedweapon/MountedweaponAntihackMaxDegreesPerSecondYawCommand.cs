using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>mountedweapon.antihack_max_degrees_per_second_yaw</c>.</summary>
/// <remarks>Full RCON name: <c>mountedweapon.antihack_max_degrees_per_second_yaw</c></remarks>
public sealed class MountedweaponAntihackMaxDegreesPerSecondYawCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "mountedweapon.antihack_max_degrees_per_second_yaw";

    /// <summary>Reads the current value of <c>mountedweapon.antihack_max_degrees_per_second_yaw</c>.</summary>
    public static MountedweaponAntihackMaxDegreesPerSecondYawCommand CreateGet()
    {
        var cmd = CreatePackage<MountedweaponAntihackMaxDegreesPerSecondYawCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>mountedweapon.antihack_max_degrees_per_second_yaw</c> to <paramref name="value"/>.</summary>
    public static MountedweaponAntihackMaxDegreesPerSecondYawCommand CreateSet(float value)
    {
        var cmd = CreatePackage<MountedweaponAntihackMaxDegreesPerSecondYawCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
