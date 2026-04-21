using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Time in minutes after which relationship/contacts data for players who have not been seen is forgotten and removed</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.forgetafterminutes</c></remarks>
public sealed class RelationshipmanagerForgetafterminutesCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.forgetafterminutes";

    /// <summary>Reads the current value of <c>relationshipmanager.forgetafterminutes</c>.</summary>
    public static RelationshipmanagerForgetafterminutesCommand CreateGet()
    {
        var cmd = CreatePackage<RelationshipmanagerForgetafterminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>relationshipmanager.forgetafterminutes</c> to <paramref name="value"/>.</summary>
    public static RelationshipmanagerForgetafterminutesCommand CreateSet(int value)
    {
        var cmd = CreatePackage<RelationshipmanagerForgetafterminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
