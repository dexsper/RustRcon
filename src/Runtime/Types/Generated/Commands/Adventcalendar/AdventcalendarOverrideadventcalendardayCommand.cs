using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>adventcalendar.overrideadventcalendarday</c>.</summary>
/// <remarks>Full RCON name: <c>adventcalendar.overrideadventcalendarday</c></remarks>
public sealed class AdventcalendarOverrideadventcalendardayCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "adventcalendar.overrideadventcalendarday";

    /// <summary>Reads the current value of <c>adventcalendar.overrideadventcalendarday</c>.</summary>
    public static AdventcalendarOverrideadventcalendardayCommand CreateGet()
    {
        var cmd = CreatePackage<AdventcalendarOverrideadventcalendardayCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>adventcalendar.overrideadventcalendarday</c> to <paramref name="value"/>.</summary>
    public static AdventcalendarOverrideadventcalendardayCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AdventcalendarOverrideadventcalendardayCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
