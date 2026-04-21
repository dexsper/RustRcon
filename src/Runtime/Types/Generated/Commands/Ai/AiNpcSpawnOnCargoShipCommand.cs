using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Spawn NPCs on the Cargo Ship. (default: true)</summary>
/// <remarks>Full RCON name: <c>ai.npc_spawn_on_cargo_ship</c></remarks>
public sealed class AiNpcSpawnOnCargoShipCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_spawn_on_cargo_ship";

    /// <summary>Reads the current value of <c>ai.npc_spawn_on_cargo_ship</c>.</summary>
    public static AiNpcSpawnOnCargoShipCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcSpawnOnCargoShipCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_spawn_on_cargo_ship</c> to <paramref name="value"/>.</summary>
    public static AiNpcSpawnOnCargoShipCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiNpcSpawnOnCargoShipCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
