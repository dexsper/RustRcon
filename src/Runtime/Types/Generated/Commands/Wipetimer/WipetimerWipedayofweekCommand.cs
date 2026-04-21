using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>0=sun,1=mon,2=tues,3=wed,4=thur,5=fri,6=sat</summary>
/// <remarks>Full RCON name: <c>wipetimer.wipedayofweek</c></remarks>
public sealed class WipetimerWipedayofweekCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "wipetimer.wipedayofweek";

    /// <summary>Reads the current value of <c>wipetimer.wipedayofweek</c>.</summary>
    public static WipetimerWipedayofweekCommand CreateGet()
    {
        var cmd = CreatePackage<WipetimerWipedayofweekCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>wipetimer.wipedayofweek</c> to <paramref name="value"/>.</summary>
    public static WipetimerWipedayofweekCommand CreateSet(int value)
    {
        var cmd = CreatePackage<WipetimerWipedayofweekCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
