using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the current count of active animal, scientist, pet, and new NPC2 brain instances on the server</summary>
/// <remarks>Full RCON name: <c>ai.brainstats</c></remarks>
public sealed class AiBrainstatsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.brainstats";

    /// <summary>Creates a new <see cref="AiBrainstatsCommand"/> command.</summary>
    public static AiBrainstatsCommand Create()
    {
        var cmd = CreatePackage<AiBrainstatsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
