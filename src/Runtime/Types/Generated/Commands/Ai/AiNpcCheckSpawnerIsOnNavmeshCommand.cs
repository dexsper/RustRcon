using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, NPC spawn points are validated to ensure they are on a valid NavMesh position before spawning; prevents NPCs from spawning in unreachable locations</summary>
/// <remarks>Full RCON name: <c>ai.npc_check_spawner_is_on_navmesh</c></remarks>
public sealed class AiNpcCheckSpawnerIsOnNavmeshCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_check_spawner_is_on_navmesh";

    /// <summary>Reads the current value of <c>ai.npc_check_spawner_is_on_navmesh</c>.</summary>
    public static AiNpcCheckSpawnerIsOnNavmeshCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcCheckSpawnerIsOnNavmeshCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_check_spawner_is_on_navmesh</c> to <paramref name="value"/>.</summary>
    public static AiNpcCheckSpawnerIsOnNavmeshCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiNpcCheckSpawnerIsOnNavmeshCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
