using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Immediately fills all spawn groups (monument NPC spawners, event spawners) to their maximum count without waiting for the normal tick interval</summary>
/// <remarks>Full RCON name: <c>spawn.fill_groups</c></remarks>
public sealed class SpawnFillGroupsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.fill_groups";

    /// <summary>Creates a new <see cref="SpawnFillGroupsCommand"/> command.</summary>
    public static SpawnFillGroupsCommand Create()
    {
        var cmd = CreatePackage<SpawnFillGroupsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
