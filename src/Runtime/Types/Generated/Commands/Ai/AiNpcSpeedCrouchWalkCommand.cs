using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_speed_walk define the speed of an npc when in the crouched walk state, and should be a number between 0 and 1. (Default: 0.1)</summary>
/// <remarks>Full RCON name: <c>ai.npc_speed_crouch_walk</c></remarks>
public sealed class AiNpcSpeedCrouchWalkCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_speed_crouch_walk";

    /// <summary>Reads the current value of <c>ai.npc_speed_crouch_walk</c>.</summary>
    public static AiNpcSpeedCrouchWalkCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcSpeedCrouchWalkCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_speed_crouch_walk</c> to <paramref name="value"/>.</summary>
    public static AiNpcSpeedCrouchWalkCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcSpeedCrouchWalkCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
