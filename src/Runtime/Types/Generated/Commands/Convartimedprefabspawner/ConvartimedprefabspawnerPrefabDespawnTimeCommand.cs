using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Time in seconds before spawned prefabs are despawned. Set to 0 to disable despawning.</summary>
/// <remarks>Full RCON name: <c>convartimedprefabspawner.prefab_despawn_time</c></remarks>
public sealed class ConvartimedprefabspawnerPrefabDespawnTimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "convartimedprefabspawner.prefab_despawn_time";

    /// <summary>Reads the current value of <c>convartimedprefabspawner.prefab_despawn_time</c>.</summary>
    public static ConvartimedprefabspawnerPrefabDespawnTimeCommand CreateGet()
    {
        var cmd = CreatePackage<ConvartimedprefabspawnerPrefabDespawnTimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>convartimedprefabspawner.prefab_despawn_time</c> to <paramref name="value"/>.</summary>
    public static ConvartimedprefabspawnerPrefabDespawnTimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ConvartimedprefabspawnerPrefabDespawnTimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
