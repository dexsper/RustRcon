using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much score players earn for hacking crates</summary>
/// <remarks>Full RCON name: <c>clan.scoreforhackingcrates</c></remarks>
public sealed class ClanScoreforhackingcratesCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "clan.scoreforhackingcrates";

    /// <summary>Reads the current value of <c>clan.scoreforhackingcrates</c>.</summary>
    public static ClanScoreforhackingcratesCommand CreateGet()
    {
        var cmd = CreatePackage<ClanScoreforhackingcratesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>clan.scoreforhackingcrates</c> to <paramref name="value"/>.</summary>
    public static ClanScoreforhackingcratesCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ClanScoreforhackingcratesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
