using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Wipes all relationship contacts data for the calling player</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.wipecontacts</c></remarks>
public sealed class RelationshipmanagerWipecontactsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.wipecontacts";

    /// <summary>Creates a new <see cref="RelationshipmanagerWipecontactsCommand"/> command.</summary>
    public static RelationshipmanagerWipecontactsCommand Create()
    {
        var cmd = CreatePackage<RelationshipmanagerWipecontactsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
