using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Destroys all drone vehicles currently spawned on the server</summary>
/// <remarks>Full RCON name: <c>vehicle.killdrones</c></remarks>
public sealed class VehicleKilldronesCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vehicle.killdrones";

    /// <summary>Creates a new <see cref="VehicleKilldronesCommand"/> command.</summary>
    public static VehicleKilldronesCommand Create()
    {
        var cmd = CreatePackage<VehicleKilldronesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
