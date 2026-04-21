using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.server_occlusion_admin_bypass</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.server_occlusion_admin_bypass</c></remarks>
public sealed class AntihackServerOcclusionAdminBypassCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.server_occlusion_admin_bypass";

    /// <summary>Reads the current value of <c>antihack.server_occlusion_admin_bypass</c>.</summary>
    public static AntihackServerOcclusionAdminBypassCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackServerOcclusionAdminBypassCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.server_occlusion_admin_bypass</c> to <paramref name="value"/>.</summary>
    public static AntihackServerOcclusionAdminBypassCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackServerOcclusionAdminBypassCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
