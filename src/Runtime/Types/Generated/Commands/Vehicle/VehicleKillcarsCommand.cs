using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Destroys all modular car vehicles currently spawned on the server</summary>
/// <remarks>Full RCON name: <c>vehicle.killcars</c></remarks>
public sealed class VehicleKillcarsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vehicle.killcars";

    /// <summary>Creates a new <see cref="VehicleKillcarsCommand"/> command.</summary>
    public static VehicleKillcarsCommand Create()
    {
        var cmd = CreatePackage<VehicleKillcarsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
