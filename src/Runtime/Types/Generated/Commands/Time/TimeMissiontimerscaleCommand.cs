using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>time.missiontimerscale</c>.</summary>
/// <remarks>Full RCON name: <c>time.missiontimerscale</c></remarks>
public sealed class TimeMissiontimerscaleCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "time.missiontimerscale";

    /// <summary>Reads the current value of <c>time.missiontimerscale</c>.</summary>
    public static TimeMissiontimerscaleCommand CreateGet()
    {
        var cmd = CreatePackage<TimeMissiontimerscaleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>time.missiontimerscale</c> to <paramref name="value"/>.</summary>
    public static TimeMissiontimerscaleCommand CreateSet(float value)
    {
        var cmd = CreatePackage<TimeMissiontimerscaleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
