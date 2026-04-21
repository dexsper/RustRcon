using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many seconds until a sleeping player is considered hostile</summary>
/// <remarks>Full RCON name: <c>npcautoturret.sleeperhostiledelay</c></remarks>
public sealed class NpcautoturretSleeperhostiledelayCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "npcautoturret.sleeperhostiledelay";

    /// <summary>Reads the current value of <c>npcautoturret.sleeperhostiledelay</c>.</summary>
    public static NpcautoturretSleeperhostiledelayCommand CreateGet()
    {
        var cmd = CreatePackage<NpcautoturretSleeperhostiledelayCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>npcautoturret.sleeperhostiledelay</c> to <paramref name="value"/>.</summary>
    public static NpcautoturretSleeperhostiledelayCommand CreateSet(float value)
    {
        var cmd = CreatePackage<NpcautoturretSleeperhostiledelayCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
