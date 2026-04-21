using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_spawn_per_tick_min_military_tunnels defineshow many will minimum spawn at once at military tunnels. (default: 1)</summary>
/// <remarks>Full RCON name: <c>ai.npc_spawn_per_tick_min_military_tunnels</c></remarks>
public sealed class AiNpcSpawnPerTickMinMilitaryTunnelsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_spawn_per_tick_min_military_tunnels";

    /// <summary>Reads the current value of <c>ai.npc_spawn_per_tick_min_military_tunnels</c>.</summary>
    public static AiNpcSpawnPerTickMinMilitaryTunnelsCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcSpawnPerTickMinMilitaryTunnelsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_spawn_per_tick_min_military_tunnels</c> to <paramref name="value"/>.</summary>
    public static AiNpcSpawnPerTickMinMilitaryTunnelsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AiNpcSpawnPerTickMinMilitaryTunnelsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
