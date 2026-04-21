using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How far away islands should be spawned, as a factor of the map size</summary>
/// <remarks>Full RCON name: <c>nexus.islandspawndistance</c></remarks>
public sealed class NexusIslandspawndistanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.islandspawndistance";

    /// <summary>Reads the current value of <c>nexus.islandspawndistance</c>.</summary>
    public static NexusIslandspawndistanceCommand CreateGet()
    {
        var cmd = CreatePackage<NexusIslandspawndistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>nexus.islandspawndistance</c> to <paramref name="value"/>.</summary>
    public static NexusIslandspawndistanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<NexusIslandspawndistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
