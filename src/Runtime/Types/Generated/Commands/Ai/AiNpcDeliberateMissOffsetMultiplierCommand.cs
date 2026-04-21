using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The offset with which the NPC will maximum miss the target. (default: 1.25)</summary>
/// <remarks>Full RCON name: <c>ai.npc_deliberate_miss_offset_multiplier</c></remarks>
public sealed class AiNpcDeliberateMissOffsetMultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_deliberate_miss_offset_multiplier";

    /// <summary>Reads the current value of <c>ai.npc_deliberate_miss_offset_multiplier</c>.</summary>
    public static AiNpcDeliberateMissOffsetMultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcDeliberateMissOffsetMultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_deliberate_miss_offset_multiplier</c> to <paramref name="value"/>.</summary>
    public static AiNpcDeliberateMissOffsetMultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcDeliberateMissOffsetMultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
