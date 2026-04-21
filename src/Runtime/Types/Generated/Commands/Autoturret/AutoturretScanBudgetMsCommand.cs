using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many milliseconds to spend on target scanning per frame</summary>
/// <remarks>Full RCON name: <c>autoturret.scan_budget_ms</c></remarks>
public sealed class AutoturretScanBudgetMsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "autoturret.scan_budget_ms";

    /// <summary>Reads the current value of <c>autoturret.scan_budget_ms</c>.</summary>
    public static AutoturretScanBudgetMsCommand CreateGet()
    {
        var cmd = CreatePackage<AutoturretScanBudgetMsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>autoturret.scan_budget_ms</c> to <paramref name="value"/>.</summary>
    public static AutoturretScanBudgetMsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AutoturretScanBudgetMsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
