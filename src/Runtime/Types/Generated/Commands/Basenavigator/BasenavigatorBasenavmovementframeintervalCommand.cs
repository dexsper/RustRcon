using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many frames between base navigation movement updates</summary>
/// <remarks>Full RCON name: <c>basenavigator.basenavmovementframeinterval</c></remarks>
public sealed class BasenavigatorBasenavmovementframeintervalCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basenavigator.basenavmovementframeinterval";

    /// <summary>Reads the current value of <c>basenavigator.basenavmovementframeinterval</c>.</summary>
    public static BasenavigatorBasenavmovementframeintervalCommand CreateGet()
    {
        var cmd = CreatePackage<BasenavigatorBasenavmovementframeintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basenavigator.basenavmovementframeinterval</c> to <paramref name="value"/>.</summary>
    public static BasenavigatorBasenavmovementframeintervalCommand CreateSet(int value)
    {
        var cmd = CreatePackage<BasenavigatorBasenavmovementframeintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
