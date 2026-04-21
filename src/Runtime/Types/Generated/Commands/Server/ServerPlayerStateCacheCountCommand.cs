using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the number of player states currently held in the in-memory player state cache</summary>
/// <remarks>Full RCON name: <c>server.player_state_cache_count</c></remarks>
public sealed class ServerPlayerStateCacheCountCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.player_state_cache_count";

    /// <summary>Creates a new <see cref="ServerPlayerStateCacheCountCommand"/> command.</summary>
    public static ServerPlayerStateCacheCountCommand Create()
    {
        var cmd = CreatePackage<ServerPlayerStateCacheCountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
