using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Wakes all currently sleeping AI information zones, forcing all sleeping NPCs within them to become active; reports zones and entity counts woken</summary>
/// <remarks>Full RCON name: <c>ai.wakesleepingai</c></remarks>
public sealed class AiWakesleepingaiCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.wakesleepingai";

    /// <summary>Creates a new <see cref="AiWakesleepingaiCommand"/> command.</summary>
    public static AiWakesleepingaiCommand Create()
    {
        var cmd = CreatePackage<AiWakesleepingaiCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
