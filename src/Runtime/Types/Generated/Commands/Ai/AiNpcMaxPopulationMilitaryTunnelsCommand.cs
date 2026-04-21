using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_max_population_military_tunnels defines the size of the npc population at military tunnels. (default: 3)</summary>
/// <remarks>Full RCON name: <c>ai.npc_max_population_military_tunnels</c></remarks>
public sealed class AiNpcMaxPopulationMilitaryTunnelsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_max_population_military_tunnels";

    /// <summary>Reads the current value of <c>ai.npc_max_population_military_tunnels</c>.</summary>
    public static AiNpcMaxPopulationMilitaryTunnelsCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcMaxPopulationMilitaryTunnelsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_max_population_military_tunnels</c> to <paramref name="value"/>.</summary>
    public static AiNpcMaxPopulationMilitaryTunnelsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AiNpcMaxPopulationMilitaryTunnelsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
