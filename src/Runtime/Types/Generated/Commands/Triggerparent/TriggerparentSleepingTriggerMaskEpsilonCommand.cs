using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>world units a trigger can move in WS before it is woken</summary>
/// <remarks>Full RCON name: <c>triggerparent.sleeping_trigger_mask_epsilon</c></remarks>
public sealed class TriggerparentSleepingTriggerMaskEpsilonCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "triggerparent.sleeping_trigger_mask_epsilon";

    /// <summary>Reads the current value of <c>triggerparent.sleeping_trigger_mask_epsilon</c>.</summary>
    public static TriggerparentSleepingTriggerMaskEpsilonCommand CreateGet()
    {
        var cmd = CreatePackage<TriggerparentSleepingTriggerMaskEpsilonCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>triggerparent.sleeping_trigger_mask_epsilon</c> to <paramref name="value"/>.</summary>
    public static TriggerparentSleepingTriggerMaskEpsilonCommand CreateSet(float value)
    {
        var cmd = CreatePackage<TriggerparentSleepingTriggerMaskEpsilonCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
