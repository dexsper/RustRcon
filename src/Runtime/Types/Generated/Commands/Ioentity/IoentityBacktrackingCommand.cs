using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of IO update passes allowed to back-track and re-process changed entities each tick; higher values improve signal propagation speed</summary>
/// <remarks>Full RCON name: <c>ioentity.backtracking</c></remarks>
public sealed class IoentityBacktrackingCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ioentity.backtracking";

    /// <summary>Reads the current value of <c>ioentity.backtracking</c>.</summary>
    public static IoentityBacktrackingCommand CreateGet()
    {
        var cmd = CreatePackage<IoentityBacktrackingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ioentity.backtracking</c> to <paramref name="value"/>.</summary>
    public static IoentityBacktrackingCommand CreateSet(int value)
    {
        var cmd = CreatePackage<IoentityBacktrackingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
