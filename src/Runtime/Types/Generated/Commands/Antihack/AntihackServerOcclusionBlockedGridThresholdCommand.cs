using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.server_occlusion_blocked_grid_threshold</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.server_occlusion_blocked_grid_threshold</c></remarks>
public sealed class AntihackServerOcclusionBlockedGridThresholdCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.server_occlusion_blocked_grid_threshold";

    /// <summary>Reads the current value of <c>antihack.server_occlusion_blocked_grid_threshold</c>.</summary>
    public static AntihackServerOcclusionBlockedGridThresholdCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackServerOcclusionBlockedGridThresholdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.server_occlusion_blocked_grid_threshold</c> to <paramref name="value"/>.</summary>
    public static AntihackServerOcclusionBlockedGridThresholdCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackServerOcclusionBlockedGridThresholdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
