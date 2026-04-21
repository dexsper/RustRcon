using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Determines whether modular cars turn into wrecks when destroyed, or just immediately gib. Default: true</summary>
/// <remarks>Full RCON name: <c>vehicle.carwrecks</c></remarks>
public sealed class VehicleCarwrecksCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vehicle.carwrecks";

    /// <summary>Reads the current value of <c>vehicle.carwrecks</c>.</summary>
    public static VehicleCarwrecksCommand CreateGet()
    {
        var cmd = CreatePackage<VehicleCarwrecksCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vehicle.carwrecks</c> to <paramref name="value"/>.</summary>
    public static VehicleCarwrecksCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<VehicleCarwrecksCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
