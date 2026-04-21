using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Kills all scientist NPCs, tunnel dwellers, and non-animal NPC2 entities currently on the server</summary>
/// <remarks>Full RCON name: <c>ai.killscientists</c></remarks>
public sealed class AiKillscientistsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.killscientists";

    /// <summary>Creates a new <see cref="AiKillscientistsCommand"/> command.</summary>
    public static AiKillscientistsCommand Create()
    {
        var cmd = CreatePackage<AiKillscientistsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
