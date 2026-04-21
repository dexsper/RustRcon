using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>mountedweapon.antihack_max_snap_degrees</c>.</summary>
/// <remarks>Full RCON name: <c>mountedweapon.antihack_max_snap_degrees</c></remarks>
public sealed class MountedweaponAntihackMaxSnapDegreesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "mountedweapon.antihack_max_snap_degrees";

    /// <summary>Reads the current value of <c>mountedweapon.antihack_max_snap_degrees</c>.</summary>
    public static MountedweaponAntihackMaxSnapDegreesCommand CreateGet()
    {
        var cmd = CreatePackage<MountedweaponAntihackMaxSnapDegreesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>mountedweapon.antihack_max_snap_degrees</c> to <paramref name="value"/>.</summary>
    public static MountedweaponAntihackMaxSnapDegreesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<MountedweaponAntihackMaxSnapDegreesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
