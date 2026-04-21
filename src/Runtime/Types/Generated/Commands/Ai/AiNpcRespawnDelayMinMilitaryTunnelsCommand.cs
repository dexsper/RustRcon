using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_respawn_delay_min_military_tunnels defines the minimum delay between spawn ticks at military tunnels. (default: 480)</summary>
/// <remarks>Full RCON name: <c>ai.npc_respawn_delay_min_military_tunnels</c></remarks>
public sealed class AiNpcRespawnDelayMinMilitaryTunnelsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_respawn_delay_min_military_tunnels";

    /// <summary>Reads the current value of <c>ai.npc_respawn_delay_min_military_tunnels</c>.</summary>
    public static AiNpcRespawnDelayMinMilitaryTunnelsCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcRespawnDelayMinMilitaryTunnelsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_respawn_delay_min_military_tunnels</c> to <paramref name="value"/>.</summary>
    public static AiNpcRespawnDelayMinMilitaryTunnelsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcRespawnDelayMinMilitaryTunnelsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
