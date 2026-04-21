using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_speed_walk define the speed of an npc when in the walk state, and should be a number between 0 and 1. (Default: 0.18)</summary>
/// <remarks>Full RCON name: <c>ai.npc_speed_walk</c></remarks>
public sealed class AiNpcSpeedWalkCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_speed_walk";

    /// <summary>Reads the current value of <c>ai.npc_speed_walk</c>.</summary>
    public static AiNpcSpeedWalkCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcSpeedWalkCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_speed_walk</c> to <paramref name="value"/>.</summary>
    public static AiNpcSpeedWalkCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcSpeedWalkCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
