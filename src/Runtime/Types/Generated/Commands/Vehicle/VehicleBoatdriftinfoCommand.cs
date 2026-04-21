using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Print out boat drift status for all boats</summary>
/// <remarks>Full RCON name: <c>vehicle.boatdriftinfo</c></remarks>
public sealed class VehicleBoatdriftinfoCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vehicle.boatdriftinfo";

    /// <summary>Creates a new <see cref="VehicleBoatdriftinfoCommand"/> command.</summary>
    public static VehicleBoatdriftinfoCommand Create()
    {
        var cmd = CreatePackage<VehicleBoatdriftinfoCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
