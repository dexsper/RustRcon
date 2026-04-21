using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Will broadcast debug ddraw information on ALL dropped items to ALL players</summary>
/// <remarks>Full RCON name: <c>droppeditem.broadcast_debug_ddraw</c></remarks>
public sealed class DroppeditemBroadcastDebugDdrawCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "droppeditem.broadcast_debug_ddraw";

    /// <summary>Reads the current value of <c>droppeditem.broadcast_debug_ddraw</c>.</summary>
    public static DroppeditemBroadcastDebugDdrawCommand CreateGet()
    {
        var cmd = CreatePackage<DroppeditemBroadcastDebugDdrawCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>droppeditem.broadcast_debug_ddraw</c> to <paramref name="value"/>.</summary>
    public static DroppeditemBroadcastDebugDdrawCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DroppeditemBroadcastDebugDdrawCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
