using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If npc_only_hurt_active_target_in_safezone is true, npcs won't any player other than their actively targeted player when in a safe zone. (default: true)</summary>
/// <remarks>Full RCON name: <c>ai.npc_only_hurt_active_target_in_safezone</c></remarks>
public sealed class AiNpcOnlyHurtActiveTargetInSafezoneCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_only_hurt_active_target_in_safezone";

    /// <summary>Reads the current value of <c>ai.npc_only_hurt_active_target_in_safezone</c>.</summary>
    public static AiNpcOnlyHurtActiveTargetInSafezoneCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcOnlyHurtActiveTargetInSafezoneCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_only_hurt_active_target_in_safezone</c> to <paramref name="value"/>.</summary>
    public static AiNpcOnlyHurtActiveTargetInSafezoneCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiNpcOnlyHurtActiveTargetInSafezoneCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
