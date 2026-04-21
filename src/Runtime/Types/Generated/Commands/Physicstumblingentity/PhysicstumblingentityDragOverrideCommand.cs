using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Override for rigidbody drag. Set to -1 to disable.</summary>
/// <remarks>Full RCON name: <c>physicstumblingentity.drag_override</c></remarks>
public sealed class PhysicstumblingentityDragOverrideCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physicstumblingentity.drag_override";

    /// <summary>Reads the current value of <c>physicstumblingentity.drag_override</c>.</summary>
    public static PhysicstumblingentityDragOverrideCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicstumblingentityDragOverrideCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physicstumblingentity.drag_override</c> to <paramref name="value"/>.</summary>
    public static PhysicstumblingentityDragOverrideCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PhysicstumblingentityDragOverrideCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
