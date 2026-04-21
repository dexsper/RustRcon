using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much score players earn for killing a player in another clan</summary>
/// <remarks>Full RCON name: <c>clan.scoreforkillingplayerinotherclan</c></remarks>
public sealed class ClanScoreforkillingplayerinotherclanCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "clan.scoreforkillingplayerinotherclan";

    /// <summary>Reads the current value of <c>clan.scoreforkillingplayerinotherclan</c>.</summary>
    public static ClanScoreforkillingplayerinotherclanCommand CreateGet()
    {
        var cmd = CreatePackage<ClanScoreforkillingplayerinotherclanCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>clan.scoreforkillingplayerinotherclan</c> to <paramref name="value"/>.</summary>
    public static ClanScoreforkillingplayerinotherclanCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ClanScoreforkillingplayerinotherclanCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
