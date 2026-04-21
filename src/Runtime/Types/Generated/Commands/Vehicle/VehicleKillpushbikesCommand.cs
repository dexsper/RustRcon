using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Destroys all push bike vehicles currently spawned on the server</summary>
/// <remarks>Full RCON name: <c>vehicle.killpushbikes</c></remarks>
public sealed class VehicleKillpushbikesCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vehicle.killpushbikes";

    /// <summary>Creates a new <see cref="VehicleKillpushbikesCommand"/> command.</summary>
    public static VehicleKillpushbikesCommand Create()
    {
        var cmd = CreatePackage<VehicleKillpushbikesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
