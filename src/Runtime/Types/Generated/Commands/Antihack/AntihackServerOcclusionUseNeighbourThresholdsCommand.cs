using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.server_occlusion_use_neighbour_thresholds</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.server_occlusion_use_neighbour_thresholds</c></remarks>
public sealed class AntihackServerOcclusionUseNeighbourThresholdsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.server_occlusion_use_neighbour_thresholds";

    /// <summary>Reads the current value of <c>antihack.server_occlusion_use_neighbour_thresholds</c>.</summary>
    public static AntihackServerOcclusionUseNeighbourThresholdsCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackServerOcclusionUseNeighbourThresholdsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.server_occlusion_use_neighbour_thresholds</c> to <paramref name="value"/>.</summary>
    public static AntihackServerOcclusionUseNeighbourThresholdsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackServerOcclusionUseNeighbourThresholdsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
