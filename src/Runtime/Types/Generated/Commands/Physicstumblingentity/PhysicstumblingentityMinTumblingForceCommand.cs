using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Minimum force applied on collision to cause tumbling</summary>
/// <remarks>Full RCON name: <c>physicstumblingentity.min_tumbling_force</c></remarks>
public sealed class PhysicstumblingentityMinTumblingForceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physicstumblingentity.min_tumbling_force";

    /// <summary>Reads the current value of <c>physicstumblingentity.min_tumbling_force</c>.</summary>
    public static PhysicstumblingentityMinTumblingForceCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicstumblingentityMinTumblingForceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physicstumblingentity.min_tumbling_force</c> to <paramref name="value"/>.</summary>
    public static PhysicstumblingentityMinTumblingForceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PhysicstumblingentityMinTumblingForceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
