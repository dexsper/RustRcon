using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>relationshipmanager.sendinvite</c>.</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.sendinvite</c></remarks>
public sealed class RelationshipmanagerSendinviteCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.sendinvite";

    /// <summary>Creates a new <see cref="RelationshipmanagerSendinviteCommand"/> command.</summary>
    public static RelationshipmanagerSendinviteCommand Create()
    {
        var cmd = CreatePackage<RelationshipmanagerSendinviteCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
