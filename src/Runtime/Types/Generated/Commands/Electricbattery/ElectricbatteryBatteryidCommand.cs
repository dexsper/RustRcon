using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>electricbattery.batteryid</c>.</summary>
/// <remarks>Full RCON name: <c>electricbattery.batteryid</c></remarks>
public sealed class ElectricbatteryBatteryidCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "electricbattery.batteryid";

    /// <summary>Creates a new <see cref="ElectricbatteryBatteryidCommand"/> command.</summary>
    public static ElectricbatteryBatteryidCommand Create()
    {
        var cmd = CreatePackage<ElectricbatteryBatteryidCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
