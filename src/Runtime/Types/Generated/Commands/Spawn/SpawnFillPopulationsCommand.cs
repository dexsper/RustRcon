using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Immediately fills all population spawners to their target density; useful after a wipe or server restart to skip the gradual ramp-up period</summary>
/// <remarks>Full RCON name: <c>spawn.fill_populations</c></remarks>
public sealed class SpawnFillPopulationsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.fill_populations";

    /// <summary>Creates a new <see cref="SpawnFillPopulationsCommand"/> command.</summary>
    public static SpawnFillPopulationsCommand Create()
    {
        var cmd = CreatePackage<SpawnFillPopulationsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
