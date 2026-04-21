using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Destroys all train vehicles currently spawned on the server</summary>
/// <remarks>Full RCON name: <c>vehicle.killtrains</c></remarks>
public sealed class VehicleKilltrainsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vehicle.killtrains";

    /// <summary>Creates a new <see cref="VehicleKilltrainsCommand"/> command.</summary>
    public static VehicleKilltrainsCommand Create()
    {
        var cmd = CreatePackage<VehicleKilltrainsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
