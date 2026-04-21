using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_speed_walk define the speed of an npc when in the run state, and should be a number between 0 and 1. (Default: 0.4)</summary>
/// <remarks>Full RCON name: <c>ai.npc_speed_run</c></remarks>
public sealed class AiNpcSpeedRunCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_speed_run";

    /// <summary>Reads the current value of <c>ai.npc_speed_run</c>.</summary>
    public static AiNpcSpeedRunCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcSpeedRunCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_speed_run</c> to <paramref name="value"/>.</summary>
    public static AiNpcSpeedRunCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcSpeedRunCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
