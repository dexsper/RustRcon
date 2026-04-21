using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Minimum relative velocity at which a physics collision generates a bounce response; lower values cause more objects to bounce on light impacts</summary>
/// <remarks>Full RCON name: <c>physics.bouncethreshold</c></remarks>
public sealed class PhysicsBouncethresholdCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.bouncethreshold";

    /// <summary>Reads the current value of <c>physics.bouncethreshold</c>.</summary>
    public static PhysicsBouncethresholdCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicsBouncethresholdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physics.bouncethreshold</c> to <paramref name="value"/>.</summary>
    public static PhysicsBouncethresholdCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PhysicsBouncethresholdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
