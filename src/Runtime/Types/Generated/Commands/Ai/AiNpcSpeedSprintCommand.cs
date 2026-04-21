using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_speed_walk define the speed of an npc when in the sprint state, and should be a number between 0 and 1. (Default: 1.0)</summary>
/// <remarks>Full RCON name: <c>ai.npc_speed_sprint</c></remarks>
public sealed class AiNpcSpeedSprintCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_speed_sprint";

    /// <summary>Reads the current value of <c>ai.npc_speed_sprint</c>.</summary>
    public static AiNpcSpeedSprintCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcSpeedSprintCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_speed_sprint</c> to <paramref name="value"/>.</summary>
    public static AiNpcSpeedSprintCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcSpeedSprintCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
