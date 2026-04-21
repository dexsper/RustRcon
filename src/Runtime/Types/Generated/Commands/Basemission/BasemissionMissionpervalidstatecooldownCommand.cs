using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Minimum time (s) between revalidating individual missions via updateMissionValidStateWorkQueue</summary>
/// <remarks>Full RCON name: <c>basemission.missionpervalidstatecooldown</c></remarks>
public sealed class BasemissionMissionpervalidstatecooldownCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basemission.missionpervalidstatecooldown";

    /// <summary>Reads the current value of <c>basemission.missionpervalidstatecooldown</c>.</summary>
    public static BasemissionMissionpervalidstatecooldownCommand CreateGet()
    {
        var cmd = CreatePackage<BasemissionMissionpervalidstatecooldownCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basemission.missionpervalidstatecooldown</c> to <paramref name="value"/>.</summary>
    public static BasemissionMissionpervalidstatecooldownCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BasemissionMissionpervalidstatecooldownCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
