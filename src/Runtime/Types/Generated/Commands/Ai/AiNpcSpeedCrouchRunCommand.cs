using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_speed_crouch_run define the speed of an npc when in the crouched run state, and should be a number between 0 and 1. (Default: 0.25)</summary>
/// <remarks>Full RCON name: <c>ai.npc_speed_crouch_run</c></remarks>
public sealed class AiNpcSpeedCrouchRunCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_speed_crouch_run";

    /// <summary>Reads the current value of <c>ai.npc_speed_crouch_run</c>.</summary>
    public static AiNpcSpeedCrouchRunCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcSpeedCrouchRunCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_speed_crouch_run</c> to <paramref name="value"/>.</summary>
    public static AiNpcSpeedCrouchRunCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcSpeedCrouchRunCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
