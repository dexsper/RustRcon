using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>relationshipmanager.rejectinvite</c>.</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.rejectinvite</c></remarks>
public sealed class RelationshipmanagerRejectinviteCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.rejectinvite";

    /// <summary>Creates a new <see cref="RelationshipmanagerRejectinviteCommand"/> command.</summary>
    public static RelationshipmanagerRejectinviteCommand Create()
    {
        var cmd = CreatePackage<RelationshipmanagerRejectinviteCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
