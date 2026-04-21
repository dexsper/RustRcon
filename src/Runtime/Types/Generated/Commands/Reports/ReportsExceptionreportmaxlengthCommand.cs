using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>reports.exceptionreportmaxlength</c>.</summary>
/// <remarks>Full RCON name: <c>reports.exceptionreportmaxlength</c></remarks>
public sealed class ReportsExceptionreportmaxlengthCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "reports.exceptionreportmaxlength";

    /// <summary>Reads the current value of <c>reports.exceptionreportmaxlength</c>.</summary>
    public static ReportsExceptionreportmaxlengthCommand CreateGet()
    {
        var cmd = CreatePackage<ReportsExceptionreportmaxlengthCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>reports.exceptionreportmaxlength</c> to <paramref name="value"/>.</summary>
    public static ReportsExceptionreportmaxlengthCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ReportsExceptionreportmaxlengthCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
