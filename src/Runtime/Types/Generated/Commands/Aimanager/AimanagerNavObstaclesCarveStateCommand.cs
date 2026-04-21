using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>nav_obstacles_carve_state defines which obstacles can carve the terrain. 0 - No carving, 1 - Only player construction carves, 2 - All obstacles carve.</summary>
/// <remarks>Full RCON name: <c>aimanager.nav_obstacles_carve_state</c></remarks>
public sealed class AimanagerNavObstaclesCarveStateCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aimanager.nav_obstacles_carve_state";

    /// <summary>Reads the current value of <c>aimanager.nav_obstacles_carve_state</c>.</summary>
    public static AimanagerNavObstaclesCarveStateCommand CreateGet()
    {
        var cmd = CreatePackage<AimanagerNavObstaclesCarveStateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aimanager.nav_obstacles_carve_state</c> to <paramref name="value"/>.</summary>
    public static AimanagerNavObstaclesCarveStateCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AimanagerNavObstaclesCarveStateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
