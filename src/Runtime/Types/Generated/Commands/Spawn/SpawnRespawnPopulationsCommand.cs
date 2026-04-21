using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, population spawners (animals, NPCs, resources) will respawn entities over time as they are killed or harvested</summary>
/// <remarks>Full RCON name: <c>spawn.respawn_populations</c></remarks>
public sealed class SpawnRespawnPopulationsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.respawn_populations";

    /// <summary>Reads the current value of <c>spawn.respawn_populations</c>.</summary>
    public static SpawnRespawnPopulationsCommand CreateGet()
    {
        var cmd = CreatePackage<SpawnRespawnPopulationsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>spawn.respawn_populations</c> to <paramref name="value"/>.</summary>
    public static SpawnRespawnPopulationsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<SpawnRespawnPopulationsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
