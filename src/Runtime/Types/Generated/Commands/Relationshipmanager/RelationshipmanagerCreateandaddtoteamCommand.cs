using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Creates a new team with the calling player and adds the specified player (by UID) to it; returns status string</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.createandaddtoteam</c></remarks>
public sealed class RelationshipmanagerCreateandaddtoteamCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.createandaddtoteam";

    /// <summary>Creates a new <see cref="RelationshipmanagerCreateandaddtoteamCommand"/> command.</summary>
    public static RelationshipmanagerCreateandaddtoteamCommand Create()
    {
        var cmd = CreatePackage<RelationshipmanagerCreateandaddtoteamCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
