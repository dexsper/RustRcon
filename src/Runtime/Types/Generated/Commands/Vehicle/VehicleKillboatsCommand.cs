using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Destroys all boat vehicles (rowboats, RHIBs) currently spawned on the server</summary>
/// <remarks>Full RCON name: <c>vehicle.killboats</c></remarks>
public sealed class VehicleKillboatsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vehicle.killboats";

    /// <summary>Creates a new <see cref="VehicleKillboatsCommand"/> command.</summary>
    public static VehicleKillboatsCommand Create()
    {
        var cmd = CreatePackage<VehicleKillboatsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
