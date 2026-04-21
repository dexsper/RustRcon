using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_htn_player_frustration_threshold defines where the frustration threshold for NPCs go, where they have the opportunity to change to a more aggressive tactic. (default: 3)</summary>
/// <remarks>Full RCON name: <c>ai.npc_htn_player_frustration_threshold</c></remarks>
public sealed class AiNpcHtnPlayerFrustrationThresholdCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_htn_player_frustration_threshold";

    /// <summary>Reads the current value of <c>ai.npc_htn_player_frustration_threshold</c>.</summary>
    public static AiNpcHtnPlayerFrustrationThresholdCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcHtnPlayerFrustrationThresholdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_htn_player_frustration_threshold</c> to <paramref name="value"/>.</summary>
    public static AiNpcHtnPlayerFrustrationThresholdCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AiNpcHtnPlayerFrustrationThresholdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
