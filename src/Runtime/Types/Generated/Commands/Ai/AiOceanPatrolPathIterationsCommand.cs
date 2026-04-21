using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of path-finding iterations used when calculating NPC ocean patrol routes; higher values produce better paths at more CPU cost</summary>
/// <remarks>Full RCON name: <c>ai.ocean_patrol_path_iterations</c></remarks>
public sealed class AiOceanPatrolPathIterationsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.ocean_patrol_path_iterations";

    /// <summary>Reads the current value of <c>ai.ocean_patrol_path_iterations</c>.</summary>
    public static AiOceanPatrolPathIterationsCommand CreateGet()
    {
        var cmd = CreatePackage<AiOceanPatrolPathIterationsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.ocean_patrol_path_iterations</c> to <paramref name="value"/>.</summary>
    public static AiOceanPatrolPathIterationsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AiOceanPatrolPathIterationsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
