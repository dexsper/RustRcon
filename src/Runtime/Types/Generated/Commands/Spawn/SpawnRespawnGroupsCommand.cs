using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, spawn groups (monument NPCs, timed event spawners) will respawn their entities after they are cleared</summary>
/// <remarks>Full RCON name: <c>spawn.respawn_groups</c></remarks>
public sealed class SpawnRespawnGroupsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.respawn_groups";

    /// <summary>Reads the current value of <c>spawn.respawn_groups</c>.</summary>
    public static SpawnRespawnGroupsCommand CreateGet()
    {
        var cmd = CreatePackage<SpawnRespawnGroupsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>spawn.respawn_groups</c> to <paramref name="value"/>.</summary>
    public static SpawnRespawnGroupsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<SpawnRespawnGroupsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
