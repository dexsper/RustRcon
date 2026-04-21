using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much score players earn for destroying other player's tool cupboards</summary>
/// <remarks>Full RCON name: <c>clan.scorefordestroyingtoolcupboards</c></remarks>
public sealed class ClanScorefordestroyingtoolcupboardsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "clan.scorefordestroyingtoolcupboards";

    /// <summary>Reads the current value of <c>clan.scorefordestroyingtoolcupboards</c>.</summary>
    public static ClanScorefordestroyingtoolcupboardsCommand CreateGet()
    {
        var cmd = CreatePackage<ClanScorefordestroyingtoolcupboardsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>clan.scorefordestroyingtoolcupboards</c> to <paramref name="value"/>.</summary>
    public static ClanScorefordestroyingtoolcupboardsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ClanScorefordestroyingtoolcupboardsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
