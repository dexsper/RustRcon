using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a table of current spawn scalar values including player fraction, excess, population rate, density, and group rate; pass --json for machine-readable output</summary>
/// <remarks>Full RCON name: <c>spawn.scalars</c></remarks>
public sealed class SpawnScalarsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.scalars";

    /// <summary>Creates a new <see cref="SpawnScalarsCommand"/> command.</summary>
    public static SpawnScalarsCommand Create()
    {
        var cmd = CreatePackage<SpawnScalarsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
