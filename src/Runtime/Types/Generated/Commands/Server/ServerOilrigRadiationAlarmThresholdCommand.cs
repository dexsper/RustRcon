using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Radiation level at which the oil rig alarm triggers; 0 means the alarm activates immediately when any radiation is present</summary>
/// <remarks>Full RCON name: <c>server.oilrig_radiation_alarm_threshold</c></remarks>
public sealed class ServerOilrigRadiationAlarmThresholdCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.oilrig_radiation_alarm_threshold";

    /// <summary>Reads the current value of <c>server.oilrig_radiation_alarm_threshold</c>.</summary>
    public static ServerOilrigRadiationAlarmThresholdCommand CreateGet()
    {
        var cmd = CreatePackage<ServerOilrigRadiationAlarmThresholdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.oilrig_radiation_alarm_threshold</c> to <paramref name="value"/>.</summary>
    public static ServerOilrigRadiationAlarmThresholdCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerOilrigRadiationAlarmThresholdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
