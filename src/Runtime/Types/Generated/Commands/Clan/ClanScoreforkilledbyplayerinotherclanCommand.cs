using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much score players earn for being killed by a player in another clan (this value should be negative)</summary>
/// <remarks>Full RCON name: <c>clan.scoreforkilledbyplayerinotherclan</c></remarks>
public sealed class ClanScoreforkilledbyplayerinotherclanCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "clan.scoreforkilledbyplayerinotherclan";

    /// <summary>Reads the current value of <c>clan.scoreforkilledbyplayerinotherclan</c>.</summary>
    public static ClanScoreforkilledbyplayerinotherclanCommand CreateGet()
    {
        var cmd = CreatePackage<ClanScoreforkilledbyplayerinotherclanCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>clan.scoreforkilledbyplayerinotherclan</c> to <paramref name="value"/>.</summary>
    public static ClanScoreforkilledbyplayerinotherclanCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ClanScoreforkilledbyplayerinotherclanCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
