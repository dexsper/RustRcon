using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The maximum amount physics ticks per frame on clients. If things are taking too long, time slows down</summary>
/// <remarks>Full RCON name: <c>time.cl_maxstepsperframe</c></remarks>
public sealed class TimeClMaxstepsperframeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "time.cl_maxstepsperframe";

    /// <summary>Reads the current value of <c>time.cl_maxstepsperframe</c>.</summary>
    public static TimeClMaxstepsperframeCommand CreateGet()
    {
        var cmd = CreatePackage<TimeClMaxstepsperframeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>time.cl_maxstepsperframe</c> to <paramref name="value"/>.</summary>
    public static TimeClMaxstepsperframeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<TimeClMaxstepsperframeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
