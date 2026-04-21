using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Unix timestamp (seconds) for the upcoming wipe. Overrides all other convars if set to a time in the future.</summary>
/// <remarks>Full RCON name: <c>wipetimer.wipeunixtimestampoverride</c></remarks>
public sealed class WipetimerWipeunixtimestampoverrideCommand : BaseConVarCommand<long>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "wipetimer.wipeunixtimestampoverride";

    /// <summary>Reads the current value of <c>wipetimer.wipeunixtimestampoverride</c>.</summary>
    public static WipetimerWipeunixtimestampoverrideCommand CreateGet()
    {
        var cmd = CreatePackage<WipetimerWipeunixtimestampoverrideCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>wipetimer.wipeunixtimestampoverride</c> to <paramref name="value"/>.</summary>
    public static WipetimerWipeunixtimestampoverrideCommand CreateSet(long value)
    {
        var cmd = CreatePackage<WipetimerWipeunixtimestampoverrideCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
