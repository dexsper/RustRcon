using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_valid_aim_cone defines how close their aim needs to be on target in order to fire. (default: 0.8)</summary>
/// <remarks>Full RCON name: <c>ai.npc_valid_aim_cone</c></remarks>
public sealed class AiNpcValidAimConeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_valid_aim_cone";

    /// <summary>Reads the current value of <c>ai.npc_valid_aim_cone</c>.</summary>
    public static AiNpcValidAimConeCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcValidAimConeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_valid_aim_cone</c> to <paramref name="value"/>.</summary>
    public static AiNpcValidAimConeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcValidAimConeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
