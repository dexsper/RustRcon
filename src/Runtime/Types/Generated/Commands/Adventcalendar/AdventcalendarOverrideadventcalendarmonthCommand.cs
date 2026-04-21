using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>adventcalendar.overrideadventcalendarmonth</c>.</summary>
/// <remarks>Full RCON name: <c>adventcalendar.overrideadventcalendarmonth</c></remarks>
public sealed class AdventcalendarOverrideadventcalendarmonthCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "adventcalendar.overrideadventcalendarmonth";

    /// <summary>Reads the current value of <c>adventcalendar.overrideadventcalendarmonth</c>.</summary>
    public static AdventcalendarOverrideadventcalendarmonthCommand CreateGet()
    {
        var cmd = CreatePackage<AdventcalendarOverrideadventcalendarmonthCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>adventcalendar.overrideadventcalendarmonth</c> to <paramref name="value"/>.</summary>
    public static AdventcalendarOverrideadventcalendarmonthCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AdventcalendarOverrideadventcalendarmonthCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
