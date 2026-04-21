using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Variance in seconds to add/subtract from the spawn interval</summary>
/// <remarks>Full RCON name: <c>convartimedprefabspawner.prefab_spawn_interval_variance</c></remarks>
public sealed class ConvartimedprefabspawnerPrefabSpawnIntervalVarianceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "convartimedprefabspawner.prefab_spawn_interval_variance";

    /// <summary>Reads the current value of <c>convartimedprefabspawner.prefab_spawn_interval_variance</c>.</summary>
    public static ConvartimedprefabspawnerPrefabSpawnIntervalVarianceCommand CreateGet()
    {
        var cmd = CreatePackage<ConvartimedprefabspawnerPrefabSpawnIntervalVarianceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>convartimedprefabspawner.prefab_spawn_interval_variance</c> to <paramref name="value"/>.</summary>
    public static ConvartimedprefabspawnerPrefabSpawnIntervalVarianceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ConvartimedprefabspawnerPrefabSpawnIntervalVarianceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
