using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.melee_terraincheck</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.melee_terraincheck</c></remarks>
public sealed class AntihackMeleeTerraincheckCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.melee_terraincheck";

    /// <summary>Reads the current value of <c>antihack.melee_terraincheck</c>.</summary>
    public static AntihackMeleeTerraincheckCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackMeleeTerraincheckCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.melee_terraincheck</c> to <paramref name="value"/>.</summary>
    public static AntihackMeleeTerraincheckCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackMeleeTerraincheckCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
