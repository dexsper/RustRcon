using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Kills all animal NPCs and animal NPC2 entities currently on the server</summary>
/// <remarks>Full RCON name: <c>ai.killanimals</c></remarks>
public sealed class AiKillanimalsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.killanimals";

    /// <summary>Creates a new <see cref="AiKillanimalsCommand"/> command.</summary>
    public static AiKillanimalsCommand Create()
    {
        var cmd = CreatePackage<AiKillanimalsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
