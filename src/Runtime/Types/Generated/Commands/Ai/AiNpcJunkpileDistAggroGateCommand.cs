using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_junkpile_dist_aggro_gate define at what range (or closer) a junkpile scientist will get aggressive. (Default: 8)</summary>
/// <remarks>Full RCON name: <c>ai.npc_junkpile_dist_aggro_gate</c></remarks>
public sealed class AiNpcJunkpileDistAggroGateCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_junkpile_dist_aggro_gate";

    /// <summary>Reads the current value of <c>ai.npc_junkpile_dist_aggro_gate</c>.</summary>
    public static AiNpcJunkpileDistAggroGateCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcJunkpileDistAggroGateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_junkpile_dist_aggro_gate</c> to <paramref name="value"/>.</summary>
    public static AiNpcJunkpileDistAggroGateCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcJunkpileDistAggroGateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
