using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.terrain_check_geometry</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.terrain_check_geometry</c></remarks>
public sealed class AntihackTerrainCheckGeometryCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.terrain_check_geometry";

    /// <summary>Reads the current value of <c>antihack.terrain_check_geometry</c>.</summary>
    public static AntihackTerrainCheckGeometryCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackTerrainCheckGeometryCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.terrain_check_geometry</c> to <paramref name="value"/>.</summary>
    public static AntihackTerrainCheckGeometryCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackTerrainCheckGeometryCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
