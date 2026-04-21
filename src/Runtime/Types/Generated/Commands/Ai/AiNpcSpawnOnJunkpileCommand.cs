using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Spawn NPCs on junkpiles (default: true)</summary>
/// <remarks>Full RCON name: <c>ai.npc_spawn_on_junkpile</c></remarks>
public sealed class AiNpcSpawnOnJunkpileCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_spawn_on_junkpile";

    /// <summary>Reads the current value of <c>ai.npc_spawn_on_junkpile</c>.</summary>
    public static AiNpcSpawnOnJunkpileCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcSpawnOnJunkpileCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_spawn_on_junkpile</c> to <paramref name="value"/>.</summary>
    public static AiNpcSpawnOnJunkpileCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiNpcSpawnOnJunkpileCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
