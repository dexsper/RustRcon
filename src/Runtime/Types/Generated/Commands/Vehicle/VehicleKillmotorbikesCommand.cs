using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Destroys all motorbike vehicles currently spawned on the server</summary>
/// <remarks>Full RCON name: <c>vehicle.killmotorbikes</c></remarks>
public sealed class VehicleKillmotorbikesCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vehicle.killmotorbikes";

    /// <summary>Creates a new <see cref="VehicleKillmotorbikesCommand"/> command.</summary>
    public static VehicleKillmotorbikesCommand Create()
    {
        var cmd = CreatePackage<VehicleKillmotorbikesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
