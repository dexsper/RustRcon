using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(center vec3) (extents vec3)</summary>
/// <remarks>Full RCON name: <c>physics.setbounds</c></remarks>
public sealed class PhysicsSetboundsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.setbounds";

    /// <summary>Creates a new <see cref="PhysicsSetboundsCommand"/> command.</summary>
    public static PhysicsSetboundsCommand Create()
    {
        var cmd = CreatePackage<PhysicsSetboundsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
