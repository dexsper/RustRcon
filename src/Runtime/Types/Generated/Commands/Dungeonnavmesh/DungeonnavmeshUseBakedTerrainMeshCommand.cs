using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>dungeonnavmesh.use_baked_terrain_mesh</c>.</summary>
/// <remarks>Full RCON name: <c>dungeonnavmesh.use_baked_terrain_mesh</c></remarks>
public sealed class DungeonnavmeshUseBakedTerrainMeshCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "dungeonnavmesh.use_baked_terrain_mesh";

    /// <summary>Reads the current value of <c>dungeonnavmesh.use_baked_terrain_mesh</c>.</summary>
    public static DungeonnavmeshUseBakedTerrainMeshCommand CreateGet()
    {
        var cmd = CreatePackage<DungeonnavmeshUseBakedTerrainMeshCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>dungeonnavmesh.use_baked_terrain_mesh</c> to <paramref name="value"/>.</summary>
    public static DungeonnavmeshUseBakedTerrainMeshCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DungeonnavmeshUseBakedTerrainMeshCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
