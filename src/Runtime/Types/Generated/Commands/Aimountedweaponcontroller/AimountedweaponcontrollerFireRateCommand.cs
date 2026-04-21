using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>aimountedweaponcontroller.fire_rate</c>.</summary>
/// <remarks>Full RCON name: <c>aimountedweaponcontroller.fire_rate</c></remarks>
public sealed class AimountedweaponcontrollerFireRateCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aimountedweaponcontroller.fire_rate";

    /// <summary>Reads the current value of <c>aimountedweaponcontroller.fire_rate</c>.</summary>
    public static AimountedweaponcontrollerFireRateCommand CreateGet()
    {
        var cmd = CreatePackage<AimountedweaponcontrollerFireRateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aimountedweaponcontroller.fire_rate</c> to <paramref name="value"/>.</summary>
    public static AimountedweaponcontrollerFireRateCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AimountedweaponcontrollerFireRateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
