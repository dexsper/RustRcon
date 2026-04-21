using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Creates a new team with the calling player as leader; fails if teams are disabled (maxTeamSize == 0)</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.trycreateteam</c></remarks>
public sealed class RelationshipmanagerTrycreateteamCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.trycreateteam";

    /// <summary>Creates a new <see cref="RelationshipmanagerTrycreateteamCommand"/> command.</summary>
    public static RelationshipmanagerTrycreateteamCommand Create()
    {
        var cmd = CreatePackage<RelationshipmanagerTrycreateteamCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
