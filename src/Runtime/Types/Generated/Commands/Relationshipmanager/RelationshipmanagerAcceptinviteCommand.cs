using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>relationshipmanager.acceptinvite</c>.</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.acceptinvite</c></remarks>
public sealed class RelationshipmanagerAcceptinviteCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.acceptinvite";

    /// <summary>Creates a new <see cref="RelationshipmanagerAcceptinviteCommand"/> command.</summary>
    public static RelationshipmanagerAcceptinviteCommand Create()
    {
        var cmd = CreatePackage<RelationshipmanagerAcceptinviteCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
