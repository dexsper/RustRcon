using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>aimountedweaponcontroller.burst_length</c>.</summary>
/// <remarks>Full RCON name: <c>aimountedweaponcontroller.burst_length</c></remarks>
public sealed class AimountedweaponcontrollerBurstLengthCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aimountedweaponcontroller.burst_length";

    /// <summary>Reads the current value of <c>aimountedweaponcontroller.burst_length</c>.</summary>
    public static AimountedweaponcontrollerBurstLengthCommand CreateGet()
    {
        var cmd = CreatePackage<AimountedweaponcontrollerBurstLengthCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aimountedweaponcontroller.burst_length</c> to <paramref name="value"/>.</summary>
    public static AimountedweaponcontrollerBurstLengthCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AimountedweaponcontrollerBurstLengthCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
