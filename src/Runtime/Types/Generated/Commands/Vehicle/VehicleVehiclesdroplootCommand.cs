using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Determines whether vehicles drop storage items when destroyed. Default: true</summary>
/// <remarks>Full RCON name: <c>vehicle.vehiclesdroploot</c></remarks>
public sealed class VehicleVehiclesdroplootCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vehicle.vehiclesdroploot";

    /// <summary>Reads the current value of <c>vehicle.vehiclesdroploot</c>.</summary>
    public static VehicleVehiclesdroplootCommand CreateGet()
    {
        var cmd = CreatePackage<VehicleVehiclesdroplootCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vehicle.vehiclesdroploot</c> to <paramref name="value"/>.</summary>
    public static VehicleVehiclesdroplootCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<VehicleVehiclesdroplootCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
