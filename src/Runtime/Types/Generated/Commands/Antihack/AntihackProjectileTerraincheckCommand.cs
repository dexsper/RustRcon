using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.projectile_terraincheck</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.projectile_terraincheck</c></remarks>
public sealed class AntihackProjectileTerraincheckCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.projectile_terraincheck";

    /// <summary>Reads the current value of <c>antihack.projectile_terraincheck</c>.</summary>
    public static AntihackProjectileTerraincheckCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackProjectileTerraincheckCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.projectile_terraincheck</c> to <paramref name="value"/>.</summary>
    public static AntihackProjectileTerraincheckCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackProjectileTerraincheckCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
