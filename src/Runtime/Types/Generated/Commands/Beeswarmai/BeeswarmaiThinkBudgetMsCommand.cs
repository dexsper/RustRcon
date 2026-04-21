using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many milliseconds to spend on thinking per frame</summary>
/// <remarks>Full RCON name: <c>beeswarmai.think_budget_ms</c></remarks>
public sealed class BeeswarmaiThinkBudgetMsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "beeswarmai.think_budget_ms";

    /// <summary>Reads the current value of <c>beeswarmai.think_budget_ms</c>.</summary>
    public static BeeswarmaiThinkBudgetMsCommand CreateGet()
    {
        var cmd = CreatePackage<BeeswarmaiThinkBudgetMsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>beeswarmai.think_budget_ms</c> to <paramref name="value"/>.</summary>
    public static BeeswarmaiThinkBudgetMsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BeeswarmaiThinkBudgetMsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
