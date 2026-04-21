using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Size of the LRU player-state cache; higher values keep more player states in memory, reducing disk reads when reconnecting players</summary>
/// <remarks>Full RCON name: <c>server.player_state_cache_size</c></remarks>
public sealed class ServerPlayerStateCacheSizeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.player_state_cache_size";

    /// <summary>Reads the current value of <c>server.player_state_cache_size</c>.</summary>
    public static ServerPlayerStateCacheSizeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPlayerStateCacheSizeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.player_state_cache_size</c> to <paramref name="value"/>.</summary>
    public static ServerPlayerStateCacheSizeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerPlayerStateCacheSizeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
