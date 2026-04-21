using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>relationshipmanager.contacts</c>.</summary>
/// <remarks>Full RCON name: <c>relationshipmanager.contacts</c></remarks>
public sealed class RelationshipmanagerContactsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "relationshipmanager.contacts";

    /// <summary>Reads the current value of <c>relationshipmanager.contacts</c>.</summary>
    public static RelationshipmanagerContactsCommand CreateGet()
    {
        var cmd = CreatePackage<RelationshipmanagerContactsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>relationshipmanager.contacts</c> to <paramref name="value"/>.</summary>
    public static RelationshipmanagerContactsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<RelationshipmanagerContactsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
