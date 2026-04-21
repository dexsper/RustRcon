using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the combined world-space bounding box of the entity the calling admin is looking at; useful for verifying collider extents</summary>
/// <remarks>Full RCON name: <c>physics.getbounds</c></remarks>
public sealed class PhysicsGetboundsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.getbounds";

    /// <summary>Creates a new <see cref="PhysicsGetboundsCommand"/> command.</summary>
    public static PhysicsGetboundsCommand Create()
    {
        var cmd = CreatePackage<PhysicsGetboundsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
