using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Deletes all spawned entities belonging to the named population(s); pass one or more population names as arguments to target specific groups</summary>
/// <remarks>Full RCON name: <c>spawn.delete_populations</c></remarks>
public sealed class SpawnDeletePopulationsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.delete_populations";

    /// <summary>Creates a new <see cref="SpawnDeletePopulationsCommand"/> command.</summary>
    public static SpawnDeletePopulationsCommand Create()
    {
        var cmd = CreatePackage<SpawnDeletePopulationsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
