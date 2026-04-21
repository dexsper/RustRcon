using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.terrain_padding</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.terrain_padding</c></remarks>
public sealed class AntihackTerrainPaddingCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.terrain_padding";

    /// <summary>Reads the current value of <c>antihack.terrain_padding</c>.</summary>
    public static AntihackTerrainPaddingCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackTerrainPaddingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.terrain_padding</c> to <paramref name="value"/>.</summary>
    public static AntihackTerrainPaddingCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackTerrainPaddingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
