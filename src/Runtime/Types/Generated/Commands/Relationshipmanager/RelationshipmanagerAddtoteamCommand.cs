using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Adds the calling player to their existing team, creating the team entry if needed</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.addtoteam</c></remarks>
public sealed class RelationshipmanagerAddtoteamCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.addtoteam";

    /// <summary>Creates a new <see cref="RelationshipmanagerAddtoteamCommand"/> command.</summary>
    public static RelationshipmanagerAddtoteamCommand Create()
    {
        var cmd = CreatePackage<RelationshipmanagerAddtoteamCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
