using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, logs ground-watch trigger events to the console, showing when players are detected as off the ground or falling through the world</summary>
/// <remarks>Full RCON name: <c>physics.groundwatchdebug</c></remarks>
public sealed class PhysicsGroundwatchdebugCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.groundwatchdebug";

    /// <summary>Reads the current value of <c>physics.groundwatchdebug</c>.</summary>
    public static PhysicsGroundwatchdebugCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicsGroundwatchdebugCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physics.groundwatchdebug</c> to <paramref name="value"/>.</summary>
    public static PhysicsGroundwatchdebugCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PhysicsGroundwatchdebugCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
