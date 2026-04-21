using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Whether Rigidbody components are removed from DroppedItems when sleeping</summary>
/// <remarks>Full RCON name: <c>droppeditem.remove_rb_on_sleep</c></remarks>
public sealed class DroppeditemRemoveRbOnSleepCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "droppeditem.remove_rb_on_sleep";

    /// <summary>Reads the current value of <c>droppeditem.remove_rb_on_sleep</c>.</summary>
    public static DroppeditemRemoveRbOnSleepCommand CreateGet()
    {
        var cmd = CreatePackage<DroppeditemRemoveRbOnSleepCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>droppeditem.remove_rb_on_sleep</c> to <paramref name="value"/>.</summary>
    public static DroppeditemRemoveRbOnSleepCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DroppeditemRemoveRbOnSleepCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
