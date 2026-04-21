using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>mountedweapon.antihack_max_degrees_per_second_pitch</c>.</summary>
/// <remarks>Full RCON name: <c>mountedweapon.antihack_max_degrees_per_second_pitch</c></remarks>
public sealed class MountedweaponAntihackMaxDegreesPerSecondPitchCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "mountedweapon.antihack_max_degrees_per_second_pitch";

    /// <summary>Reads the current value of <c>mountedweapon.antihack_max_degrees_per_second_pitch</c>.</summary>
    public static MountedweaponAntihackMaxDegreesPerSecondPitchCommand CreateGet()
    {
        var cmd = CreatePackage<MountedweaponAntihackMaxDegreesPerSecondPitchCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>mountedweapon.antihack_max_degrees_per_second_pitch</c> to <paramref name="value"/>.</summary>
    public static MountedweaponAntihackMaxDegreesPerSecondPitchCommand CreateSet(float value)
    {
        var cmd = CreatePackage<MountedweaponAntihackMaxDegreesPerSecondPitchCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
