using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>relationshipmanager.leaveteam</c>.</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.leaveteam</c></remarks>
public sealed class RelationshipmanagerLeaveteamCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.leaveteam";

    /// <summary>Creates a new <see cref="RelationshipmanagerLeaveteamCommand"/> command.</summary>
    public static RelationshipmanagerLeaveteamCommand Create()
    {
        var cmd = CreatePackage<RelationshipmanagerLeaveteamCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
