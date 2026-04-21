using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>relationshipmanager.promote</c>.</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.promote</c></remarks>
public sealed class RelationshipmanagerPromoteCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.promote";

    /// <summary>Creates a new <see cref="RelationshipmanagerPromoteCommand"/> command.</summary>
    public static RelationshipmanagerPromoteCommand Create()
    {
        var cmd = CreatePackage<RelationshipmanagerPromoteCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
