using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Do players and vehicles collide with trees?</summary>
/// <remarks>Full RCON name: <c>physics.treecollision</c></remarks>
public sealed class PhysicsTreecollisionCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.treecollision";

    /// <summary>Reads the current value of <c>physics.treecollision</c>.</summary>
    public static PhysicsTreecollisionCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicsTreecollisionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physics.treecollision</c> to <paramref name="value"/>.</summary>
    public static PhysicsTreecollisionCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PhysicsTreecollisionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
