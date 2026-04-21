using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of relationship entries (contacts) each player can store; older entries are evicted when the limit is reached</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.maxplayerrelationships</c></remarks>
public sealed class RelationshipmanagerMaxplayerrelationshipsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.maxplayerrelationships";

    /// <summary>Reads the current value of <c>relationshipmanager.maxplayerrelationships</c>.</summary>
    public static RelationshipmanagerMaxplayerrelationshipsCommand CreateGet()
    {
        var cmd = CreatePackage<RelationshipmanagerMaxplayerrelationshipsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>relationshipmanager.maxplayerrelationships</c> to <paramref name="value"/>.</summary>
    public static RelationshipmanagerMaxplayerrelationshipsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<RelationshipmanagerMaxplayerrelationshipsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
