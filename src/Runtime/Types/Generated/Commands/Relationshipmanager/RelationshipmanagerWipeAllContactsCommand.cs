using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Wipes all relationship contacts data for every player on the server; admin-only</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.wipe_all_contacts</c></remarks>
public sealed class RelationshipmanagerWipeAllContactsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.wipe_all_contacts";

    /// <summary>Creates a new <see cref="RelationshipmanagerWipeAllContactsCommand"/> command.</summary>
    public static RelationshipmanagerWipeAllContactsCommand Create()
    {
        var cmd = CreatePackage<RelationshipmanagerWipeAllContactsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
