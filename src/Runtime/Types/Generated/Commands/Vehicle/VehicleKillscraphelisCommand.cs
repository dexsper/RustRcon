using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Destroys all scrap transport helicopter vehicles currently spawned on the server</summary>
/// <remarks>Full RCON name: <c>vehicle.killscraphelis</c></remarks>
public sealed class VehicleKillscraphelisCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vehicle.killscraphelis";

    /// <summary>Creates a new <see cref="VehicleKillscraphelisCommand"/> command.</summary>
    public static VehicleKillscraphelisCommand Create()
    {
        var cmd = CreatePackage<VehicleKillscraphelisCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
