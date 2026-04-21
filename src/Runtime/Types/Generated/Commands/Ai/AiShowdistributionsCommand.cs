using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Editor-only: teleports the caller to a top-down view, fills NPC populations, then draws DDraw labels and lines showing each NPC category and closest neighbour</summary>
/// <remarks>Full RCON name: <c>ai.showdistributions</c></remarks>
public sealed class AiShowdistributionsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.showdistributions";

    /// <summary>Creates a new <see cref="AiShowdistributionsCommand"/> command.</summary>
    public static AiShowdistributionsCommand Create()
    {
        var cmd = CreatePackage<AiShowdistributionsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
