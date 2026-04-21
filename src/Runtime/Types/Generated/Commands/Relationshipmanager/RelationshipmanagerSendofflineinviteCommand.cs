using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>relationshipmanager.sendofflineinvite</c>.</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.sendofflineinvite</c></remarks>
public sealed class RelationshipmanagerSendofflineinviteCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.sendofflineinvite";

    /// <summary>Creates a new <see cref="RelationshipmanagerSendofflineinviteCommand"/> command.</summary>
    public static RelationshipmanagerSendofflineinviteCommand Create()
    {
        var cmd = CreatePackage<RelationshipmanagerSendofflineinviteCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
