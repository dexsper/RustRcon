using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>ai_dormant_max_wakeup_per_tick defines the maximum number of dormant agents we will wake up in a single tick. (default: 30)</summary>
/// <remarks>Full RCON name: <c>aimanager.ai_dormant_max_wakeup_per_tick</c></remarks>
public sealed class AimanagerAiDormantMaxWakeupPerTickCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aimanager.ai_dormant_max_wakeup_per_tick";

    /// <summary>Reads the current value of <c>aimanager.ai_dormant_max_wakeup_per_tick</c>.</summary>
    public static AimanagerAiDormantMaxWakeupPerTickCommand CreateGet()
    {
        var cmd = CreatePackage<AimanagerAiDormantMaxWakeupPerTickCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aimanager.ai_dormant_max_wakeup_per_tick</c> to <paramref name="value"/>.</summary>
    public static AimanagerAiDormantMaxWakeupPerTickCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AimanagerAiDormantMaxWakeupPerTickCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
