using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Print out what is taking so long in the IO frame budget</summary>
/// <remarks>Full RCON name: <c>ioentity.debugbudget</c></remarks>
public sealed class IoentityDebugbudgetCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ioentity.debugbudget";

    /// <summary>Reads the current value of <c>ioentity.debugbudget</c>.</summary>
    public static IoentityDebugbudgetCommand CreateGet()
    {
        var cmd = CreatePackage<IoentityDebugbudgetCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ioentity.debugbudget</c> to <paramref name="value"/>.</summary>
    public static IoentityDebugbudgetCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<IoentityDebugbudgetCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
