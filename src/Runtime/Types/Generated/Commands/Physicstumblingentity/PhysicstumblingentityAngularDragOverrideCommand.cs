using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Override for rigidbody angular drag. Set to -1 to disable.</summary>
/// <remarks>Full RCON name: <c>physicstumblingentity.angular_drag_override</c></remarks>
public sealed class PhysicstumblingentityAngularDragOverrideCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physicstumblingentity.angular_drag_override";

    /// <summary>Reads the current value of <c>physicstumblingentity.angular_drag_override</c>.</summary>
    public static PhysicstumblingentityAngularDragOverrideCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicstumblingentityAngularDragOverrideCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physicstumblingentity.angular_drag_override</c> to <paramref name="value"/>.</summary>
    public static PhysicstumblingentityAngularDragOverrideCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PhysicstumblingentityAngularDragOverrideCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
