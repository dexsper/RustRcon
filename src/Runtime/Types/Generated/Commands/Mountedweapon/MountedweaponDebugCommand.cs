using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>mountedweapon.debug</c>.</summary>
/// <remarks>Full RCON name: <c>mountedweapon.debug</c></remarks>
public sealed class MountedweaponDebugCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "mountedweapon.debug";

    /// <summary>Reads the current value of <c>mountedweapon.debug</c>.</summary>
    public static MountedweaponDebugCommand CreateGet()
    {
        var cmd = CreatePackage<MountedweaponDebugCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>mountedweapon.debug</c> to <paramref name="value"/>.</summary>
    public static MountedweaponDebugCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<MountedweaponDebugCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
