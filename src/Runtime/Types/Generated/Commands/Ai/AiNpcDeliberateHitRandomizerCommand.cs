using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The percentage away from a maximum miss the randomizer is allowed to travel when shooting to deliberately hit the target (we don't want perfect hits with every shot). (default: 0.85f)</summary>
/// <remarks>Full RCON name: <c>ai.npc_deliberate_hit_randomizer</c></remarks>
public sealed class AiNpcDeliberateHitRandomizerCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_deliberate_hit_randomizer";

    /// <summary>Reads the current value of <c>ai.npc_deliberate_hit_randomizer</c>.</summary>
    public static AiNpcDeliberateHitRandomizerCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcDeliberateHitRandomizerCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_deliberate_hit_randomizer</c> to <paramref name="value"/>.</summary>
    public static AiNpcDeliberateHitRandomizerCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcDeliberateHitRandomizerCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
