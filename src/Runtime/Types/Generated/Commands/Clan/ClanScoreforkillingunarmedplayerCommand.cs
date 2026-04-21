using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much score players earn for killing unarmed players (this value should be negative)</summary>
/// <remarks>Full RCON name: <c>clan.scoreforkillingunarmedplayer</c></remarks>
public sealed class ClanScoreforkillingunarmedplayerCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "clan.scoreforkillingunarmedplayer";

    /// <summary>Reads the current value of <c>clan.scoreforkillingunarmedplayer</c>.</summary>
    public static ClanScoreforkillingunarmedplayerCommand CreateGet()
    {
        var cmd = CreatePackage<ClanScoreforkillingunarmedplayerCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>clan.scoreforkillingunarmedplayer</c> to <paramref name="value"/>.</summary>
    public static ClanScoreforkillingunarmedplayerCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ClanScoreforkillingunarmedplayerCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
