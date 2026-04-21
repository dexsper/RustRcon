using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Toggles the sleep/wake state of the entity the calling admin player is looking at (within 5m); admin-only</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.sleeptoggle</c></remarks>
public sealed class RelationshipmanagerSleeptoggleCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.sleeptoggle";

    /// <summary>Creates a new <see cref="RelationshipmanagerSleeptoggleCommand"/> command.</summary>
    public static RelationshipmanagerSleeptoggleCommand Create()
    {
        var cmd = CreatePackage<RelationshipmanagerSleeptoggleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
