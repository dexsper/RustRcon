using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Spawn NPCs on deep sea islands (default: false)</summary>
/// <remarks>Full RCON name: <c>ai.npc_spawn_on_deep_sea_islands</c></remarks>
public sealed class AiNpcSpawnOnDeepSeaIslandsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_spawn_on_deep_sea_islands";

    /// <summary>Reads the current value of <c>ai.npc_spawn_on_deep_sea_islands</c>.</summary>
    public static AiNpcSpawnOnDeepSeaIslandsCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcSpawnOnDeepSeaIslandsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_spawn_on_deep_sea_islands</c> to <paramref name="value"/>.</summary>
    public static AiNpcSpawnOnDeepSeaIslandsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiNpcSpawnOnDeepSeaIslandsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
