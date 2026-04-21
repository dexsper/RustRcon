using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>When generating, the interval in seconds in between each spawn groups fill (dwellings/crates/scientists on island, ghost ships). Increase if you're experiencing lag when the deep sea is opening.</summary>
/// <remarks>Full RCON name: <c>deepsea.spawngroups_spawninterval</c></remarks>
public sealed class DeepseaSpawngroupsSpawnintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.spawngroups_spawninterval";

    /// <summary>Reads the current value of <c>deepsea.spawngroups_spawninterval</c>.</summary>
    public static DeepseaSpawngroupsSpawnintervalCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaSpawngroupsSpawnintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.spawngroups_spawninterval</c> to <paramref name="value"/>.</summary>
    public static DeepseaSpawngroupsSpawnintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaSpawngroupsSpawnintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
