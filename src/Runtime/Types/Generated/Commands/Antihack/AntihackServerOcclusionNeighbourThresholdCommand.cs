using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.server_occlusion_neighbour_threshold</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.server_occlusion_neighbour_threshold</c></remarks>
public sealed class AntihackServerOcclusionNeighbourThresholdCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.server_occlusion_neighbour_threshold";

    /// <summary>Reads the current value of <c>antihack.server_occlusion_neighbour_threshold</c>.</summary>
    public static AntihackServerOcclusionNeighbourThresholdCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackServerOcclusionNeighbourThresholdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.server_occlusion_neighbour_threshold</c> to <paramref name="value"/>.</summary>
    public static AntihackServerOcclusionNeighbourThresholdCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackServerOcclusionNeighbourThresholdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
