using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_valid_mounted_aim_cone defines how close their aim needs to be on target in order to fire while mounted. (default: 0.92)</summary>
/// <remarks>Full RCON name: <c>ai.npc_valid_mounted_aim_cone</c></remarks>
public sealed class AiNpcValidMountedAimConeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_valid_mounted_aim_cone";

    /// <summary>Reads the current value of <c>ai.npc_valid_mounted_aim_cone</c>.</summary>
    public static AiNpcValidMountedAimConeCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcValidMountedAimConeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_valid_mounted_aim_cone</c> to <paramref name="value"/>.</summary>
    public static AiNpcValidMountedAimConeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcValidMountedAimConeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
