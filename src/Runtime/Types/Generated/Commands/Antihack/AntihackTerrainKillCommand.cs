using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.terrain_kill</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.terrain_kill</c></remarks>
public sealed class AntihackTerrainKillCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.terrain_kill";

    /// <summary>Reads the current value of <c>antihack.terrain_kill</c>.</summary>
    public static AntihackTerrainKillCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackTerrainKillCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.terrain_kill</c> to <paramref name="value"/>.</summary>
    public static AntihackTerrainKillCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackTerrainKillCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
