using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Immediately stops all train entities on the server, zeroing their speed; useful for clearing deadlocked train paths</summary>
/// <remarks>Full RCON name: <c>vehicle.stop_all_trains</c></remarks>
public sealed class VehicleStopAllTrainsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vehicle.stop_all_trains";

    /// <summary>Creates a new <see cref="VehicleStopAllTrainsCommand"/> command.</summary>
    public static VehicleStopAllTrainsCommand Create()
    {
        var cmd = CreatePackage<VehicleStopAllTrainsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
