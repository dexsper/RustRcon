using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The maximum amount of nodes processed each frame in the asynchronous pathfinding process. Increasing this value will cause the paths to be processed faster, but can cause some hiccups in frame rate. Default value is 100, a good range for tuning is between 50 and 500.</summary>
/// <remarks>Full RCON name: <c>aimanager.pathfindingiterationsperframe</c></remarks>
public sealed class AimanagerPathfindingiterationsperframeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aimanager.pathfindingiterationsperframe";

    /// <summary>Reads the current value of <c>aimanager.pathfindingiterationsperframe</c>.</summary>
    public static AimanagerPathfindingiterationsperframeCommand CreateGet()
    {
        var cmd = CreatePackage<AimanagerPathfindingiterationsperframeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aimanager.pathfindingiterationsperframe</c> to <paramref name="value"/>.</summary>
    public static AimanagerPathfindingiterationsperframeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AimanagerPathfindingiterationsperframeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
