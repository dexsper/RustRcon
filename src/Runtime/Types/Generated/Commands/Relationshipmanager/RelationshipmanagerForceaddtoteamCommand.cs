using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Adds a player to a team whether they are on the server or not</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.forceaddtoteam</c></remarks>
public sealed class RelationshipmanagerForceaddtoteamCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.forceaddtoteam";

    /// <summary>Creates a new <see cref="RelationshipmanagerForceaddtoteamCommand"/> command.</summary>
    public static RelationshipmanagerForceaddtoteamCommand Create()
    {
        var cmd = CreatePackage<RelationshipmanagerForceaddtoteamCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
