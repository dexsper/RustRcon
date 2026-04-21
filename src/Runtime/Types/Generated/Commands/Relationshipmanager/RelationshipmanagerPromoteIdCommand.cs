using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>relationshipmanager.promote_id</c>.</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.promote_id</c></remarks>
public sealed class RelationshipmanagerPromoteIdCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.promote_id";

    /// <summary>Creates a new <see cref="RelationshipmanagerPromoteIdCommand"/> command.</summary>
    public static RelationshipmanagerPromoteIdCommand Create()
    {
        var cmd = CreatePackage<RelationshipmanagerPromoteIdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
