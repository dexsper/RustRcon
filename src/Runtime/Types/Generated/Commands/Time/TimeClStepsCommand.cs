using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Desired physics ticks per second on clients</summary>
/// <remarks>Full RCON name: <c>time.cl_steps</c></remarks>
public sealed class TimeClStepsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "time.cl_steps";

    /// <summary>Reads the current value of <c>time.cl_steps</c>.</summary>
    public static TimeClStepsCommand CreateGet()
    {
        var cmd = CreatePackage<TimeClStepsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>time.cl_steps</c> to <paramref name="value"/>.</summary>
    public static TimeClStepsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<TimeClStepsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
