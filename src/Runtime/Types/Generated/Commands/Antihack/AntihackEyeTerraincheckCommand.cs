using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.eye_terraincheck</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.eye_terraincheck</c></remarks>
public sealed class AntihackEyeTerraincheckCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.eye_terraincheck";

    /// <summary>Reads the current value of <c>antihack.eye_terraincheck</c>.</summary>
    public static AntihackEyeTerraincheckCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackEyeTerraincheckCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.eye_terraincheck</c> to <paramref name="value"/>.</summary>
    public static AntihackEyeTerraincheckCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackEyeTerraincheckCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
