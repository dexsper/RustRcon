using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Sends a fake team invite from the given team ID to the calling player; used for testing team invite UI flow</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.fakeinvite</c></remarks>
public sealed class RelationshipmanagerFakeinviteCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.fakeinvite";

    /// <summary>Creates a new <see cref="RelationshipmanagerFakeinviteCommand"/> command.</summary>
    public static RelationshipmanagerFakeinviteCommand Create()
    {
        var cmd = CreatePackage<RelationshipmanagerFakeinviteCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
