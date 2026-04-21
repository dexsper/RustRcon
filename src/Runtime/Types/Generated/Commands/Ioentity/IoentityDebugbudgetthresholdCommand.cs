using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Ignore frames with a lower ms than this while debugBudget is active</summary>
/// <remarks>Full RCON name: <c>ioentity.debugbudgetthreshold</c></remarks>
public sealed class IoentityDebugbudgetthresholdCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ioentity.debugbudgetthreshold";

    /// <summary>Reads the current value of <c>ioentity.debugbudgetthreshold</c>.</summary>
    public static IoentityDebugbudgetthresholdCommand CreateGet()
    {
        var cmd = CreatePackage<IoentityDebugbudgetthresholdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ioentity.debugbudgetthreshold</c> to <paramref name="value"/>.</summary>
    public static IoentityDebugbudgetthresholdCommand CreateSet(float value)
    {
        var cmd = CreatePackage<IoentityDebugbudgetthresholdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
