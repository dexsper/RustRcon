using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.server_occlusion_save_grid</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.server_occlusion_save_grid</c></remarks>
public sealed class AntihackServerOcclusionSaveGridCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.server_occlusion_save_grid";

    /// <summary>Reads the current value of <c>antihack.server_occlusion_save_grid</c>.</summary>
    public static AntihackServerOcclusionSaveGridCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackServerOcclusionSaveGridCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.server_occlusion_save_grid</c> to <paramref name="value"/>.</summary>
    public static AntihackServerOcclusionSaveGridCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackServerOcclusionSaveGridCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
