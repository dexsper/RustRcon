using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Gravity multiplier</summary>
/// <remarks>Full RCON name: <c>physics.gravity</c></remarks>
public sealed class PhysicsGravityCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.gravity";

    /// <summary>Reads the current value of <c>physics.gravity</c>.</summary>
    public static PhysicsGravityCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicsGravityCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physics.gravity</c> to <paramref name="value"/>.</summary>
    public static PhysicsGravityCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PhysicsGravityCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
