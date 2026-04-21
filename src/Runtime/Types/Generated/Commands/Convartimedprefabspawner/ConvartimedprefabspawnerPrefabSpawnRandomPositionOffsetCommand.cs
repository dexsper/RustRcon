using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Maximum random offset (sphere radius) from the spawner's position when spawning prefabs</summary>
/// <remarks>Full RCON name: <c>convartimedprefabspawner.prefab_spawn_random_position_offset</c></remarks>
public sealed class ConvartimedprefabspawnerPrefabSpawnRandomPositionOffsetCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "convartimedprefabspawner.prefab_spawn_random_position_offset";

    /// <summary>Reads the current value of <c>convartimedprefabspawner.prefab_spawn_random_position_offset</c>.</summary>
    public static ConvartimedprefabspawnerPrefabSpawnRandomPositionOffsetCommand CreateGet()
    {
        var cmd = CreatePackage<ConvartimedprefabspawnerPrefabSpawnRandomPositionOffsetCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>convartimedprefabspawner.prefab_spawn_random_position_offset</c> to <paramref name="value"/>.</summary>
    public static ConvartimedprefabspawnerPrefabSpawnRandomPositionOffsetCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ConvartimedprefabspawnerPrefabSpawnRandomPositionOffsetCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
