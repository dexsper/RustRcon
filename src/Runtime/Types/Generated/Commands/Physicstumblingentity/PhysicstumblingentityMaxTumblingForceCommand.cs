using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Maximum force applied on collision to cause tumbling</summary>
/// <remarks>Full RCON name: <c>physicstumblingentity.max_tumbling_force</c></remarks>
public sealed class PhysicstumblingentityMaxTumblingForceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physicstumblingentity.max_tumbling_force";

    /// <summary>Reads the current value of <c>physicstumblingentity.max_tumbling_force</c>.</summary>
    public static PhysicstumblingentityMaxTumblingForceCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicstumblingentityMaxTumblingForceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physicstumblingentity.max_tumbling_force</c> to <paramref name="value"/>.</summary>
    public static PhysicstumblingentityMaxTumblingForceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PhysicstumblingentityMaxTumblingForceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
