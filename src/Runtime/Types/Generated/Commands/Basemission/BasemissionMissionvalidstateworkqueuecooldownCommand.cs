using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Minimum time (s) between starting runs of updateMissionValidStateWorkQueue</summary>
/// <remarks>Full RCON name: <c>basemission.missionvalidstateworkqueuecooldown</c></remarks>
public sealed class BasemissionMissionvalidstateworkqueuecooldownCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basemission.missionvalidstateworkqueuecooldown";

    /// <summary>Reads the current value of <c>basemission.missionvalidstateworkqueuecooldown</c>.</summary>
    public static BasemissionMissionvalidstateworkqueuecooldownCommand CreateGet()
    {
        var cmd = CreatePackage<BasemissionMissionvalidstateworkqueuecooldownCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basemission.missionvalidstateworkqueuecooldown</c> to <paramref name="value"/>.</summary>
    public static BasemissionMissionvalidstateworkqueuecooldownCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BasemissionMissionvalidstateworkqueuecooldownCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
