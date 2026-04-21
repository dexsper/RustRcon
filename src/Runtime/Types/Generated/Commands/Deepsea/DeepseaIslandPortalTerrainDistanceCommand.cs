using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Distance in metres from the main island terrain edge at which deep sea entrance portals are placed; affects how far offshore players must travel before encountering a portal</summary>
/// <remarks>Full RCON name: <c>deepsea.island_portal_terrain_distance</c></remarks>
public sealed class DeepseaIslandPortalTerrainDistanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.island_portal_terrain_distance";

    /// <summary>Reads the current value of <c>deepsea.island_portal_terrain_distance</c>.</summary>
    public static DeepseaIslandPortalTerrainDistanceCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaIslandPortalTerrainDistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.island_portal_terrain_distance</c> to <paramref name="value"/>.</summary>
    public static DeepseaIslandPortalTerrainDistanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaIslandPortalTerrainDistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
