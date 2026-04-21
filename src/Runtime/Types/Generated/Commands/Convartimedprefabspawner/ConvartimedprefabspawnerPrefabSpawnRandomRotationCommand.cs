using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If true, spawned prefabs will have a random rotation</summary>
/// <remarks>Full RCON name: <c>convartimedprefabspawner.prefab_spawn_random_rotation</c></remarks>
public sealed class ConvartimedprefabspawnerPrefabSpawnRandomRotationCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "convartimedprefabspawner.prefab_spawn_random_rotation";

    /// <summary>Reads the current value of <c>convartimedprefabspawner.prefab_spawn_random_rotation</c>.</summary>
    public static ConvartimedprefabspawnerPrefabSpawnRandomRotationCommand CreateGet()
    {
        var cmd = CreatePackage<ConvartimedprefabspawnerPrefabSpawnRandomRotationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>convartimedprefabspawner.prefab_spawn_random_rotation</c> to <paramref name="value"/>.</summary>
    public static ConvartimedprefabspawnerPrefabSpawnRandomRotationCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ConvartimedprefabspawnerPrefabSpawnRandomRotationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
