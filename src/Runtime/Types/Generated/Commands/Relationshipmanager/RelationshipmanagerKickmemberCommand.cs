using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>relationshipmanager.kickmember</c>.</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.kickmember</c></remarks>
public sealed class RelationshipmanagerKickmemberCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.kickmember";

    /// <summary>Creates a new <see cref="RelationshipmanagerKickmemberCommand"/> command.</summary>
    public static RelationshipmanagerKickmemberCommand Create()
    {
        var cmd = CreatePackage<RelationshipmanagerKickmemberCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
