using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_alertness_zero_detection_mod define the threshold of visibility required to detect an enemy when alertness is zero. (Default: 0.5)</summary>
/// <remarks>Full RCON name: <c>ai.npc_alertness_zero_detection_mod</c></remarks>
public sealed class AiNpcAlertnessZeroDetectionModCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_alertness_zero_detection_mod";

    /// <summary>Reads the current value of <c>ai.npc_alertness_zero_detection_mod</c>.</summary>
    public static AiNpcAlertnessZeroDetectionModCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcAlertnessZeroDetectionModCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_alertness_zero_detection_mod</c> to <paramref name="value"/>.</summary>
    public static AiNpcAlertnessZeroDetectionModCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcAlertnessZeroDetectionModCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
