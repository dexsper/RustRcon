using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Determines whether trains stop automatically when there's no-one on them. Default: false</summary>
/// <remarks>Full RCON name: <c>vehicle.trainskeeprunning</c></remarks>
public sealed class VehicleTrainskeeprunningCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vehicle.trainskeeprunning";

    /// <summary>Reads the current value of <c>vehicle.trainskeeprunning</c>.</summary>
    public static VehicleTrainskeeprunningCommand CreateGet()
    {
        var cmd = CreatePackage<VehicleTrainskeeprunningCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vehicle.trainskeeprunning</c> to <paramref name="value"/>.</summary>
    public static VehicleTrainskeeprunningCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<VehicleTrainskeeprunningCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
