using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If enabled then players will need to be near a Clan Table to make changes to clans</summary>
/// <remarks>Full RCON name: <c>clan.editsrequireclantable</c></remarks>
public sealed class ClanEditsrequireclantableCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "clan.editsrequireclantable";

    /// <summary>Reads the current value of <c>clan.editsrequireclantable</c>.</summary>
    public static ClanEditsrequireclantableCommand CreateGet()
    {
        var cmd = CreatePackage<ClanEditsrequireclantableCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>clan.editsrequireclantable</c> to <paramref name="value"/>.</summary>
    public static ClanEditsrequireclantableCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ClanEditsrequireclantableCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
