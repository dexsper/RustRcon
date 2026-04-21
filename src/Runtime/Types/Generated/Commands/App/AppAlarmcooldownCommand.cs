using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Cooldown time before alarms can send another notification (in seconds)</summary>
/// <remarks>Full RCON name: <c>app.alarmcooldown</c></remarks>
public sealed class AppAlarmcooldownCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "app.alarmcooldown";

    /// <summary>Reads the current value of <c>app.alarmcooldown</c>.</summary>
    public static AppAlarmcooldownCommand CreateGet()
    {
        var cmd = CreatePackage<AppAlarmcooldownCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>app.alarmcooldown</c> to <paramref name="value"/>.</summary>
    public static AppAlarmcooldownCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AppAlarmcooldownCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
