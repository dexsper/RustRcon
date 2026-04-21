using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>sensecomponent.minrefreshintervalseconds</c>.</summary>
/// <remarks>Full RCON name: <c>sensecomponent.minrefreshintervalseconds</c></remarks>
public sealed class SensecomponentMinrefreshintervalsecondsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "sensecomponent.minrefreshintervalseconds";

    /// <summary>Reads the current value of <c>sensecomponent.minrefreshintervalseconds</c>.</summary>
    public static SensecomponentMinrefreshintervalsecondsCommand CreateGet()
    {
        var cmd = CreatePackage<SensecomponentMinrefreshintervalsecondsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>sensecomponent.minrefreshintervalseconds</c> to <paramref name="value"/>.</summary>
    public static SensecomponentMinrefreshintervalsecondsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SensecomponentMinrefreshintervalsecondsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
