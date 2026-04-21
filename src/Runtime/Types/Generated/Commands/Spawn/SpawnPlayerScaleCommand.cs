using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Multiplier applied to group spawn rates based on current player count relative to player_base; higher values cause more group spawns as the server fills up</summary>
/// <remarks>Full RCON name: <c>spawn.player_scale</c></remarks>
public sealed class SpawnPlayerScaleCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.player_scale";

    /// <summary>Reads the current value of <c>spawn.player_scale</c>.</summary>
    public static SpawnPlayerScaleCommand CreateGet()
    {
        var cmd = CreatePackage<SpawnPlayerScaleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>spawn.player_scale</c> to <paramref name="value"/>.</summary>
    public static SpawnPlayerScaleCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SpawnPlayerScaleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
