using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>mountedweapon.enable_client_authority</c>.</summary>
/// <remarks>Full RCON name: <c>mountedweapon.enable_client_authority</c></remarks>
public sealed class MountedweaponEnableClientAuthorityCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "mountedweapon.enable_client_authority";

    /// <summary>Reads the current value of <c>mountedweapon.enable_client_authority</c>.</summary>
    public static MountedweaponEnableClientAuthorityCommand CreateGet()
    {
        var cmd = CreatePackage<MountedweaponEnableClientAuthorityCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>mountedweapon.enable_client_authority</c> to <paramref name="value"/>.</summary>
    public static MountedweaponEnableClientAuthorityCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<MountedweaponEnableClientAuthorityCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
