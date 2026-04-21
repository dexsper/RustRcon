using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Desired physics ticks per second on the server</summary>
/// <remarks>Full RCON name: <c>time.sv_steps</c></remarks>
public sealed class TimeSvStepsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "time.sv_steps";

    /// <summary>Reads the current value of <c>time.sv_steps</c>.</summary>
    public static TimeSvStepsCommand CreateGet()
    {
        var cmd = CreatePackage<TimeSvStepsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>time.sv_steps</c> to <paramref name="value"/>.</summary>
    public static TimeSvStepsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<TimeSvStepsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
