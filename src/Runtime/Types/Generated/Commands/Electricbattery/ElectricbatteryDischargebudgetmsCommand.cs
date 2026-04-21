using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>electricbattery.dischargebudgetms</c>.</summary>
/// <remarks>Full RCON name: <c>electricbattery.dischargebudgetms</c></remarks>
public sealed class ElectricbatteryDischargebudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "electricbattery.dischargebudgetms";

    /// <summary>Reads the current value of <c>electricbattery.dischargebudgetms</c>.</summary>
    public static ElectricbatteryDischargebudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<ElectricbatteryDischargebudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>electricbattery.dischargebudgetms</c> to <paramref name="value"/>.</summary>
    public static ElectricbatteryDischargebudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ElectricbatteryDischargebudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
