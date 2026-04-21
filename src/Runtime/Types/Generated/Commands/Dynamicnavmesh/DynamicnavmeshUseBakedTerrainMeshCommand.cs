using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>dynamicnavmesh.use_baked_terrain_mesh</c>.</summary>
/// <remarks>Full RCON name: <c>dynamicnavmesh.use_baked_terrain_mesh</c></remarks>
public sealed class DynamicnavmeshUseBakedTerrainMeshCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "dynamicnavmesh.use_baked_terrain_mesh";

    /// <summary>Reads the current value of <c>dynamicnavmesh.use_baked_terrain_mesh</c>.</summary>
    public static DynamicnavmeshUseBakedTerrainMeshCommand CreateGet()
    {
        var cmd = CreatePackage<DynamicnavmeshUseBakedTerrainMeshCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>dynamicnavmesh.use_baked_terrain_mesh</c> to <paramref name="value"/>.</summary>
    public static DynamicnavmeshUseBakedTerrainMeshCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DynamicnavmeshUseBakedTerrainMeshCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
