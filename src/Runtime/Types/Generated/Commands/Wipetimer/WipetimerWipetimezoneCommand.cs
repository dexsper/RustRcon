using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The timezone to use for wipes. Defaults to the server's time zone if not set or invalid. Value should be a TZ identifier as seen here: https://en.wikipedia.org/wiki/List_of_tz_database_time_zones</summary>
/// <remarks>Full RCON name: <c>wipetimer.wipetimezone</c></remarks>
public sealed class WipetimerWipetimezoneCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "wipetimer.wipetimezone";

    /// <summary>Reads the current value of <c>wipetimer.wipetimezone</c>.</summary>
    public static WipetimerWipetimezoneCommand CreateGet()
    {
        var cmd = CreatePackage<WipetimerWipetimezoneCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>wipetimer.wipetimezone</c> to <paramref name="value"/>.</summary>
    public static WipetimerWipetimezoneCommand CreateSet(string value)
    {
        var cmd = CreatePackage<WipetimerWipetimezoneCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
