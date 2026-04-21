using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Time in seconds between prefab spawns. Set to 0 to disable spawning.</summary>
/// <remarks>Full RCON name: <c>convartimedprefabspawner.prefab_spawn_interval</c></remarks>
public sealed class ConvartimedprefabspawnerPrefabSpawnIntervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "convartimedprefabspawner.prefab_spawn_interval";

    /// <summary>Reads the current value of <c>convartimedprefabspawner.prefab_spawn_interval</c>.</summary>
    public static ConvartimedprefabspawnerPrefabSpawnIntervalCommand CreateGet()
    {
        var cmd = CreatePackage<ConvartimedprefabspawnerPrefabSpawnIntervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>convartimedprefabspawner.prefab_spawn_interval</c> to <paramref name="value"/>.</summary>
    public static ConvartimedprefabspawnerPrefabSpawnIntervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ConvartimedprefabspawnerPrefabSpawnIntervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
