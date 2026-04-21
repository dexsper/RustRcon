using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Base player count used when computing population spawn rates; below this value player_scale group rates are not yet applied</summary>
/// <remarks>Full RCON name: <c>spawn.player_base</c></remarks>
public sealed class SpawnPlayerBaseCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.player_base";

    /// <summary>Reads the current value of <c>spawn.player_base</c>.</summary>
    public static SpawnPlayerBaseCommand CreateGet()
    {
        var cmd = CreatePackage<SpawnPlayerBaseCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>spawn.player_base</c> to <paramref name="value"/>.</summary>
    public static SpawnPlayerBaseCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SpawnPlayerBaseCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
