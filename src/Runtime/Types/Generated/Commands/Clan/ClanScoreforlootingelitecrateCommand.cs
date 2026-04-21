using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much score players earn for looting an elite crate</summary>
/// <remarks>Full RCON name: <c>clan.scoreforlootingelitecrate</c></remarks>
public sealed class ClanScoreforlootingelitecrateCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "clan.scoreforlootingelitecrate";

    /// <summary>Reads the current value of <c>clan.scoreforlootingelitecrate</c>.</summary>
    public static ClanScoreforlootingelitecrateCommand CreateGet()
    {
        var cmd = CreatePackage<ClanScoreforlootingelitecrateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>clan.scoreforlootingelitecrate</c> to <paramref name="value"/>.</summary>
    public static ClanScoreforlootingelitecrateCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ClanScoreforlootingelitecrateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
