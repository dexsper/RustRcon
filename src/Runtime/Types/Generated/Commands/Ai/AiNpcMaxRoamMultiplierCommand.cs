using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>This is multiplied with the max roam range stat of an NPC to determine how far from its spawn point the NPC is allowed to roam. (default: 3)</summary>
/// <remarks>Full RCON name: <c>ai.npc_max_roam_multiplier</c></remarks>
public sealed class AiNpcMaxRoamMultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_max_roam_multiplier";

    /// <summary>Reads the current value of <c>ai.npc_max_roam_multiplier</c>.</summary>
    public static AiNpcMaxRoamMultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcMaxRoamMultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_max_roam_multiplier</c> to <paramref name="value"/>.</summary>
    public static AiNpcMaxRoamMultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcMaxRoamMultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
