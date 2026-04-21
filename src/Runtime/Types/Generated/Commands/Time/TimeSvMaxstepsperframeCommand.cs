using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The maximum amount physics ticks per frame on the server. If things are taking too long, time slows down</summary>
/// <remarks>Full RCON name: <c>time.sv_maxstepsperframe</c></remarks>
public sealed class TimeSvMaxstepsperframeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "time.sv_maxstepsperframe";

    /// <summary>Reads the current value of <c>time.sv_maxstepsperframe</c>.</summary>
    public static TimeSvMaxstepsperframeCommand CreateGet()
    {
        var cmd = CreatePackage<TimeSvMaxstepsperframeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>time.sv_maxstepsperframe</c> to <paramref name="value"/>.</summary>
    public static TimeSvMaxstepsperframeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<TimeSvMaxstepsperframeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
