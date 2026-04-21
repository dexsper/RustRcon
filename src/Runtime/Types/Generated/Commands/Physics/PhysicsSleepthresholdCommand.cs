using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Energy threshold below which a rigid body is put to sleep by the physics engine; lower values keep more objects awake, higher values reduce CPU usage</summary>
/// <remarks>Full RCON name: <c>physics.sleepthreshold</c></remarks>
public sealed class PhysicsSleepthresholdCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.sleepthreshold";

    /// <summary>Reads the current value of <c>physics.sleepthreshold</c>.</summary>
    public static PhysicsSleepthresholdCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicsSleepthresholdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physics.sleepthreshold</c> to <paramref name="value"/>.</summary>
    public static PhysicsSleepthresholdCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PhysicsSleepthresholdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
