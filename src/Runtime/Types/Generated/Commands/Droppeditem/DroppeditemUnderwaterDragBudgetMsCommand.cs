using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many milliseconds to spend on updating underwater drag levels</summary>
/// <remarks>Full RCON name: <c>droppeditem.underwater_drag_budget_ms</c></remarks>
public sealed class DroppeditemUnderwaterDragBudgetMsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "droppeditem.underwater_drag_budget_ms";

    /// <summary>Reads the current value of <c>droppeditem.underwater_drag_budget_ms</c>.</summary>
    public static DroppeditemUnderwaterDragBudgetMsCommand CreateGet()
    {
        var cmd = CreatePackage<DroppeditemUnderwaterDragBudgetMsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>droppeditem.underwater_drag_budget_ms</c> to <paramref name="value"/>.</summary>
    public static DroppeditemUnderwaterDragBudgetMsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DroppeditemUnderwaterDragBudgetMsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
