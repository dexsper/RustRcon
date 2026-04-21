using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_alertness_drain_rate define the rate at which we drain the alertness level of an NPC when there are no enemies in sight. (Default: 0.01)</summary>
/// <remarks>Full RCON name: <c>ai.npc_alertness_drain_rate</c></remarks>
public sealed class AiNpcAlertnessDrainRateCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_alertness_drain_rate";

    /// <summary>Reads the current value of <c>ai.npc_alertness_drain_rate</c>.</summary>
    public static AiNpcAlertnessDrainRateCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcAlertnessDrainRateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_alertness_drain_rate</c> to <paramref name="value"/>.</summary>
    public static AiNpcAlertnessDrainRateCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcAlertnessDrainRateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
