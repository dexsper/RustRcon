using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>When a player respawns give them the loadout assigned to client.RespawnLoadout (created with inventory.saveloadout)</summary>
/// <remarks>Full RCON name: <c>server.respawnwithloadout</c></remarks>
public sealed class ServerRespawnwithloadoutCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.respawnwithloadout";

    /// <summary>Reads the current value of <c>server.respawnwithloadout</c>.</summary>
    public static ServerRespawnwithloadoutCommand CreateGet()
    {
        var cmd = CreatePackage<ServerRespawnwithloadoutCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.respawnwithloadout</c> to <paramref name="value"/>.</summary>
    public static ServerRespawnwithloadoutCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerRespawnwithloadoutCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
