using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Clears the loot spawn cache used to restrict loot into each era</summary>
/// <remarks>Full RCON name: <c>server.clear_loot_spawn_cache</c></remarks>
public sealed class ServerClearLootSpawnCacheCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.clear_loot_spawn_cache";

    /// <summary>Creates a new <see cref="ServerClearLootSpawnCacheCommand"/> command.</summary>
    public static ServerClearLootSpawnCacheCommand Create()
    {
        var cmd = CreatePackage<ServerClearLootSpawnCacheCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
