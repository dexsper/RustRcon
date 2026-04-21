using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Immediately respawns all individually tracked entities that are currently missing, bypassing the normal tick_individuals delay</summary>
/// <remarks>Full RCON name: <c>spawn.fill_individuals</c></remarks>
public sealed class SpawnFillIndividualsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.fill_individuals";

    /// <summary>Creates a new <see cref="SpawnFillIndividualsCommand"/> command.</summary>
    public static SpawnFillIndividualsCommand Create()
    {
        var cmd = CreatePackage<SpawnFillIndividualsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
