using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>This is multiplied with the current alertness (0-10) to decide how long it will take for the NPC to deliberately miss again. (default: 0.33)</summary>
/// <remarks>Full RCON name: <c>ai.npc_alertness_to_aim_modifier</c></remarks>
public sealed class AiNpcAlertnessToAimModifierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_alertness_to_aim_modifier";

    /// <summary>Reads the current value of <c>ai.npc_alertness_to_aim_modifier</c>.</summary>
    public static AiNpcAlertnessToAimModifierCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcAlertnessToAimModifierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_alertness_to_aim_modifier</c> to <paramref name="value"/>.</summary>
    public static AiNpcAlertnessToAimModifierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcAlertnessToAimModifierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
