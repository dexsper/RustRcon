using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_spawn_per_tick_max_military_tunnels defines how many can maximum spawn at once at military tunnels. (default: 1)</summary>
/// <remarks>Full RCON name: <c>ai.npc_spawn_per_tick_max_military_tunnels</c></remarks>
public sealed class AiNpcSpawnPerTickMaxMilitaryTunnelsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_spawn_per_tick_max_military_tunnels";

    /// <summary>Reads the current value of <c>ai.npc_spawn_per_tick_max_military_tunnels</c>.</summary>
    public static AiNpcSpawnPerTickMaxMilitaryTunnelsCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcSpawnPerTickMaxMilitaryTunnelsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_spawn_per_tick_max_military_tunnels</c> to <paramref name="value"/>.</summary>
    public static AiNpcSpawnPerTickMaxMilitaryTunnelsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AiNpcSpawnPerTickMaxMilitaryTunnelsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
