using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Destroys all minicopter vehicles currently spawned on the server</summary>
/// <remarks>Full RCON name: <c>vehicle.killminis</c></remarks>
public sealed class VehicleKillminisCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vehicle.killminis";

    /// <summary>Creates a new <see cref="VehicleKillminisCommand"/> command.</summary>
    public static VehicleKillminisCommand Create()
    {
        var cmd = CreatePackage<VehicleKillminisCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
