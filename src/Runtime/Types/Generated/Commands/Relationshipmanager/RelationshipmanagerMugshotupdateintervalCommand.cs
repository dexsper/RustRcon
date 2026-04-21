using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Interval in seconds between mugshot (contact portrait) refresh attempts for known players</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.mugshotupdateinterval</c></remarks>
public sealed class RelationshipmanagerMugshotupdateintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.mugshotupdateinterval";

    /// <summary>Reads the current value of <c>relationshipmanager.mugshotupdateinterval</c>.</summary>
    public static RelationshipmanagerMugshotupdateintervalCommand CreateGet()
    {
        var cmd = CreatePackage<RelationshipmanagerMugshotupdateintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>relationshipmanager.mugshotupdateinterval</c> to <paramref name="value"/>.</summary>
    public static RelationshipmanagerMugshotupdateintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<RelationshipmanagerMugshotupdateintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
