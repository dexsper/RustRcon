using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.build_terraincheck</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.build_terraincheck</c></remarks>
public sealed class AntihackBuildTerraincheckCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.build_terraincheck";

    /// <summary>Reads the current value of <c>antihack.build_terraincheck</c>.</summary>
    public static AntihackBuildTerraincheckCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackBuildTerraincheckCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.build_terraincheck</c> to <paramref name="value"/>.</summary>
    public static AntihackBuildTerraincheckCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackBuildTerraincheckCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
