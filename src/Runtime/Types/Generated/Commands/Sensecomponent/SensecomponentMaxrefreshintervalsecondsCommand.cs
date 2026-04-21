using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>sensecomponent.maxrefreshintervalseconds</c>.</summary>
/// <remarks>Full RCON name: <c>sensecomponent.maxrefreshintervalseconds</c></remarks>
public sealed class SensecomponentMaxrefreshintervalsecondsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "sensecomponent.maxrefreshintervalseconds";

    /// <summary>Reads the current value of <c>sensecomponent.maxrefreshintervalseconds</c>.</summary>
    public static SensecomponentMaxrefreshintervalsecondsCommand CreateGet()
    {
        var cmd = CreatePackage<SensecomponentMaxrefreshintervalsecondsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>sensecomponent.maxrefreshintervalseconds</c> to <paramref name="value"/>.</summary>
    public static SensecomponentMaxrefreshintervalsecondsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SensecomponentMaxrefreshintervalsecondsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
