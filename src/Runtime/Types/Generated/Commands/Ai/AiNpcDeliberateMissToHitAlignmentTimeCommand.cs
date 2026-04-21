using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The time it takes for the NPC to deliberately miss to the time the NPC tries to hit its target. (default: 1.5)</summary>
/// <remarks>Full RCON name: <c>ai.npc_deliberate_miss_to_hit_alignment_time</c></remarks>
public sealed class AiNpcDeliberateMissToHitAlignmentTimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_deliberate_miss_to_hit_alignment_time";

    /// <summary>Reads the current value of <c>ai.npc_deliberate_miss_to_hit_alignment_time</c>.</summary>
    public static AiNpcDeliberateMissToHitAlignmentTimeCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcDeliberateMissToHitAlignmentTimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_deliberate_miss_to_hit_alignment_time</c> to <paramref name="value"/>.</summary>
    public static AiNpcDeliberateMissToHitAlignmentTimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcDeliberateMissToHitAlignmentTimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
