using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.terrain_penalty</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.terrain_penalty</c></remarks>
public sealed class AntihackTerrainPenaltyCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.terrain_penalty";

    /// <summary>Reads the current value of <c>antihack.terrain_penalty</c>.</summary>
    public static AntihackTerrainPenaltyCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackTerrainPenaltyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.terrain_penalty</c> to <paramref name="value"/>.</summary>
    public static AntihackTerrainPenaltyCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackTerrainPenaltyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
