using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much score players earn for reaching cargo ship</summary>
/// <remarks>Full RCON name: <c>clan.scoreforreachingcargoship</c></remarks>
public sealed class ClanScoreforreachingcargoshipCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "clan.scoreforreachingcargoship";

    /// <summary>Reads the current value of <c>clan.scoreforreachingcargoship</c>.</summary>
    public static ClanScoreforreachingcargoshipCommand CreateGet()
    {
        var cmd = CreatePackage<ClanScoreforreachingcargoshipCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>clan.scoreforreachingcargoship</c> to <paramref name="value"/>.</summary>
    public static ClanScoreforreachingcargoshipCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ClanScoreforreachingcargoshipCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
