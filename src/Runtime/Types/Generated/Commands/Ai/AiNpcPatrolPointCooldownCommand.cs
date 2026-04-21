using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_patrol_point_cooldown defines the cooldown time on a patrol point until it's available again (default: 5)</summary>
/// <remarks>Full RCON name: <c>ai.npc_patrol_point_cooldown</c></remarks>
public sealed class AiNpcPatrolPointCooldownCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_patrol_point_cooldown";

    /// <summary>Reads the current value of <c>ai.npc_patrol_point_cooldown</c>.</summary>
    public static AiNpcPatrolPointCooldownCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcPatrolPointCooldownCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_patrol_point_cooldown</c> to <paramref name="value"/>.</summary>
    public static AiNpcPatrolPointCooldownCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcPatrolPointCooldownCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
