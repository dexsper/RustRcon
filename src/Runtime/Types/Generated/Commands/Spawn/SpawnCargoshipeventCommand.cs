using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Spawns a cargo ship and starts the cargo ship event immediately, bypassing the normal random event scheduler</summary>
/// <remarks>Full RCON name: <c>spawn.cargoshipevent</c></remarks>
public sealed class SpawnCargoshipeventCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.cargoshipevent";

    /// <summary>Creates a new <see cref="SpawnCargoshipeventCommand"/> command.</summary>
    public static SpawnCargoshipeventCommand Create()
    {
        var cmd = CreatePackage<SpawnCargoshipeventCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
