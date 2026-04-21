using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the total number of player state cache entries evicted since server startup; high values suggest the cache size should be increased</summary>
/// <remarks>Full RCON name: <c>server.player_state_cache_evictions</c></remarks>
public sealed class ServerPlayerStateCacheEvictionsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.player_state_cache_evictions";

    /// <summary>Creates a new <see cref="ServerPlayerStateCacheEvictionsCommand"/> command.</summary>
    public static ServerPlayerStateCacheEvictionsCommand Create()
    {
        var cmd = CreatePackage<ServerPlayerStateCacheEvictionsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
