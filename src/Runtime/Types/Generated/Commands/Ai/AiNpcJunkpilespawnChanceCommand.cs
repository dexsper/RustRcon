using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>defines the chance for scientists to spawn at NPC junkpiles. (Default: 0.1)</summary>
/// <remarks>Full RCON name: <c>ai.npc_junkpilespawn_chance</c></remarks>
public sealed class AiNpcJunkpilespawnChanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_junkpilespawn_chance";

    /// <summary>Reads the current value of <c>ai.npc_junkpilespawn_chance</c>.</summary>
    public static AiNpcJunkpilespawnChanceCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcJunkpilespawnChanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_junkpilespawn_chance</c> to <paramref name="value"/>.</summary>
    public static AiNpcJunkpilespawnChanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcJunkpilespawnChanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
