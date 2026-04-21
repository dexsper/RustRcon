using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Server-side handler that spawns a dummy player entity at the given position and direction loaded with the Shields loadout, optionally holstering the shield; triggered by spawn.shielddummy</summary>
/// <remarks>Full RCON name: <c>spawn.svshielddummy</c></remarks>
public sealed class SpawnSvshielddummyCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.svshielddummy";

    /// <summary>Creates a new <see cref="SpawnSvshielddummyCommand"/> command.</summary>
    public static SpawnSvshielddummyCommand Create(bool value)
    {
        var cmd = CreatePackage<SpawnSvshielddummyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
