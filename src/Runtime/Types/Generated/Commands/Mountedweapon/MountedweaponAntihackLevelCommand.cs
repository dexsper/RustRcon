using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>mountedweapon.antihack_level</c>.</summary>
/// <remarks>Full RCON name: <c>mountedweapon.antihack_level</c></remarks>
public sealed class MountedweaponAntihackLevelCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "mountedweapon.antihack_level";

    /// <summary>Reads the current value of <c>mountedweapon.antihack_level</c>.</summary>
    public static MountedweaponAntihackLevelCommand CreateGet()
    {
        var cmd = CreatePackage<MountedweaponAntihackLevelCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>mountedweapon.antihack_level</c> to <paramref name="value"/>.</summary>
    public static MountedweaponAntihackLevelCommand CreateSet(int value)
    {
        var cmd = CreatePackage<MountedweaponAntihackLevelCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
