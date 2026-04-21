using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Baseline damage modifier for the new HTN Player NPCs to nerf their damage compared to the old NPCs. (default: 1.15f)</summary>
/// <remarks>Full RCON name: <c>ai.npc_htn_player_base_damage_modifier</c></remarks>
public sealed class AiNpcHtnPlayerBaseDamageModifierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_htn_player_base_damage_modifier";

    /// <summary>Reads the current value of <c>ai.npc_htn_player_base_damage_modifier</c>.</summary>
    public static AiNpcHtnPlayerBaseDamageModifierCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcHtnPlayerBaseDamageModifierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_htn_player_base_damage_modifier</c> to <paramref name="value"/>.</summary>
    public static AiNpcHtnPlayerBaseDamageModifierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcHtnPlayerBaseDamageModifierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
