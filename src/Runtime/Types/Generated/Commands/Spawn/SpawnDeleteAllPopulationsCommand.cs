using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Deletes all entities from every active population spawner on the server at once; effectively despawns all wildlife, NPCs, and resource nodes</summary>
/// <remarks>Full RCON name: <c>spawn.delete_all_populations</c></remarks>
public sealed class SpawnDeleteAllPopulationsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.delete_all_populations";

    /// <summary>Creates a new <see cref="SpawnDeleteAllPopulationsCommand"/> command.</summary>
    public static SpawnDeleteAllPopulationsCommand Create()
    {
        var cmd = CreatePackage<SpawnDeleteAllPopulationsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
