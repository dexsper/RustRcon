using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_respawn_delay_max_military_tunnels defines the maximum delay between spawn ticks at military tunnels. (default: 1920)</summary>
/// <remarks>Full RCON name: <c>ai.npc_respawn_delay_max_military_tunnels</c></remarks>
public sealed class AiNpcRespawnDelayMaxMilitaryTunnelsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_respawn_delay_max_military_tunnels";

    /// <summary>Reads the current value of <c>ai.npc_respawn_delay_max_military_tunnels</c>.</summary>
    public static AiNpcRespawnDelayMaxMilitaryTunnelsCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcRespawnDelayMaxMilitaryTunnelsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_respawn_delay_max_military_tunnels</c> to <paramref name="value"/>.</summary>
    public static AiNpcRespawnDelayMaxMilitaryTunnelsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcRespawnDelayMaxMilitaryTunnelsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
