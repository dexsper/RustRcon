using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Minimum velocity required for an object to get tumbling force applied on collision</summary>
/// <remarks>Full RCON name: <c>physicstumblingentity.velocity_threshold_for_tumbling_force</c></remarks>
public sealed class PhysicstumblingentityVelocityThresholdForTumblingForceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physicstumblingentity.velocity_threshold_for_tumbling_force";

    /// <summary>Reads the current value of <c>physicstumblingentity.velocity_threshold_for_tumbling_force</c>.</summary>
    public static PhysicstumblingentityVelocityThresholdForTumblingForceCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicstumblingentityVelocityThresholdForTumblingForceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physicstumblingentity.velocity_threshold_for_tumbling_force</c> to <paramref name="value"/>.</summary>
    public static PhysicstumblingentityVelocityThresholdForTumblingForceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PhysicstumblingentityVelocityThresholdForTumblingForceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
