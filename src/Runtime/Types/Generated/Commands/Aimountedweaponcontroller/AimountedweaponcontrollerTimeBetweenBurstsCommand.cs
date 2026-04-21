using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>aimountedweaponcontroller.time_between_bursts</c>.</summary>
/// <remarks>Full RCON name: <c>aimountedweaponcontroller.time_between_bursts</c></remarks>
public sealed class AimountedweaponcontrollerTimeBetweenBurstsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aimountedweaponcontroller.time_between_bursts";

    /// <summary>Reads the current value of <c>aimountedweaponcontroller.time_between_bursts</c>.</summary>
    public static AimountedweaponcontrollerTimeBetweenBurstsCommand CreateGet()
    {
        var cmd = CreatePackage<AimountedweaponcontrollerTimeBetweenBurstsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aimountedweaponcontroller.time_between_bursts</c> to <paramref name="value"/>.</summary>
    public static AimountedweaponcontrollerTimeBetweenBurstsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AimountedweaponcontrollerTimeBetweenBurstsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
