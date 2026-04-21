using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.use_legacy_mesh_inside_check</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.use_legacy_mesh_inside_check</c></remarks>
public sealed class AntihackUseLegacyMeshInsideCheckCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.use_legacy_mesh_inside_check";

    /// <summary>Reads the current value of <c>antihack.use_legacy_mesh_inside_check</c>.</summary>
    public static AntihackUseLegacyMeshInsideCheckCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackUseLegacyMeshInsideCheckCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.use_legacy_mesh_inside_check</c> to <paramref name="value"/>.</summary>
    public static AntihackUseLegacyMeshInsideCheckCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackUseLegacyMeshInsideCheckCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
