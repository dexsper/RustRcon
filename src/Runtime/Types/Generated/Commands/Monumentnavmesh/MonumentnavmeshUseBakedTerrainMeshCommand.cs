using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>monumentnavmesh.use_baked_terrain_mesh</c>.</summary>
/// <remarks>Full RCON name: <c>monumentnavmesh.use_baked_terrain_mesh</c></remarks>
public sealed class MonumentnavmeshUseBakedTerrainMeshCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "monumentnavmesh.use_baked_terrain_mesh";

    /// <summary>Reads the current value of <c>monumentnavmesh.use_baked_terrain_mesh</c>.</summary>
    public static MonumentnavmeshUseBakedTerrainMeshCommand CreateGet()
    {
        var cmd = CreatePackage<MonumentnavmeshUseBakedTerrainMeshCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>monumentnavmesh.use_baked_terrain_mesh</c> to <paramref name="value"/>.</summary>
    public static MonumentnavmeshUseBakedTerrainMeshCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<MonumentnavmeshUseBakedTerrainMeshCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
