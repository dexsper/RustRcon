using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Distance in metres within which two players must be for a 'seen' relationship event to be recorded</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.seendistance</c></remarks>
public sealed class RelationshipmanagerSeendistanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.seendistance";

    /// <summary>Reads the current value of <c>relationshipmanager.seendistance</c>.</summary>
    public static RelationshipmanagerSeendistanceCommand CreateGet()
    {
        var cmd = CreatePackage<RelationshipmanagerSeendistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>relationshipmanager.seendistance</c> to <paramref name="value"/>.</summary>
    public static RelationshipmanagerSeendistanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<RelationshipmanagerSeendistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
