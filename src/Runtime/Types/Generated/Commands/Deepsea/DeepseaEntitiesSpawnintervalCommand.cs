using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>When generating, the interval in seconds in between each entity spawn (island, ghost ship and floating city). Increase if you're experiencing lag when the deep sea is opening.</summary>
/// <remarks>Full RCON name: <c>deepsea.entities_spawninterval</c></remarks>
public sealed class DeepseaEntitiesSpawnintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.entities_spawninterval";

    /// <summary>Reads the current value of <c>deepsea.entities_spawninterval</c>.</summary>
    public static DeepseaEntitiesSpawnintervalCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaEntitiesSpawnintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.entities_spawninterval</c> to <paramref name="value"/>.</summary>
    public static DeepseaEntitiesSpawnintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaEntitiesSpawnintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
