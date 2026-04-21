using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of real-time hours before a scheduled wipe at which the pre-wipe event schedule begins running; registered as event_hours_before_wipe</summary>
/// <remarks>Full RCON name: <c>eventschedulewipeoffset.event_hours_before_wipe</c></remarks>
public sealed class EventschedulewipeoffsetEventHoursBeforeWipeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "eventschedulewipeoffset.event_hours_before_wipe";

    /// <summary>Reads the current value of <c>eventschedulewipeoffset.event_hours_before_wipe</c>.</summary>
    public static EventschedulewipeoffsetEventHoursBeforeWipeCommand CreateGet()
    {
        var cmd = CreatePackage<EventschedulewipeoffsetEventHoursBeforeWipeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>eventschedulewipeoffset.event_hours_before_wipe</c> to <paramref name="value"/>.</summary>
    public static EventschedulewipeoffsetEventHoursBeforeWipeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<EventschedulewipeoffsetEventHoursBeforeWipeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
