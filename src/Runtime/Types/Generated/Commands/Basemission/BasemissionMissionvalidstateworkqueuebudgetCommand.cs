using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long per frame (ms) to spend processing updateMissionValidStateWorkQueue</summary>
/// <remarks>Full RCON name: <c>basemission.missionvalidstateworkqueuebudget</c></remarks>
public sealed class BasemissionMissionvalidstateworkqueuebudgetCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basemission.missionvalidstateworkqueuebudget";

    /// <summary>Reads the current value of <c>basemission.missionvalidstateworkqueuebudget</c>.</summary>
    public static BasemissionMissionvalidstateworkqueuebudgetCommand CreateGet()
    {
        var cmd = CreatePackage<BasemissionMissionvalidstateworkqueuebudgetCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basemission.missionvalidstateworkqueuebudget</c> to <paramref name="value"/>.</summary>
    public static BasemissionMissionvalidstateworkqueuebudgetCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BasemissionMissionvalidstateworkqueuebudgetCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
