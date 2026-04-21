using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of players allowed in a single team; 0 = teams disabled; changing this at runtime updates all active teams</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.maxteamsize</c></remarks>
public sealed class RelationshipmanagerMaxteamsizeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.maxteamsize";

    /// <summary>Reads the current value of <c>relationshipmanager.maxteamsize</c>.</summary>
    public static RelationshipmanagerMaxteamsizeCommand CreateGet()
    {
        var cmd = CreatePackage<RelationshipmanagerMaxteamsizeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>relationshipmanager.maxteamsize</c> to <paramref name="value"/>.</summary>
    public static RelationshipmanagerMaxteamsizeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<RelationshipmanagerMaxteamsizeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
