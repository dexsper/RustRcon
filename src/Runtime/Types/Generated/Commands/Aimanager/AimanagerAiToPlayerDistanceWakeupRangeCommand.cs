using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If an agent is beyond this distance to a player, it's flagged for becoming dormant.</summary>
/// <remarks>Full RCON name: <c>aimanager.ai_to_player_distance_wakeup_range</c></remarks>
public sealed class AimanagerAiToPlayerDistanceWakeupRangeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aimanager.ai_to_player_distance_wakeup_range";

    /// <summary>Reads the current value of <c>aimanager.ai_to_player_distance_wakeup_range</c>.</summary>
    public static AimanagerAiToPlayerDistanceWakeupRangeCommand CreateGet()
    {
        var cmd = CreatePackage<AimanagerAiToPlayerDistanceWakeupRangeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aimanager.ai_to_player_distance_wakeup_range</c> to <paramref name="value"/>.</summary>
    public static AimanagerAiToPlayerDistanceWakeupRangeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AimanagerAiToPlayerDistanceWakeupRangeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
