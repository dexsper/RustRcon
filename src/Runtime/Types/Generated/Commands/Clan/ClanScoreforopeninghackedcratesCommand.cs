using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much score players earn for opening hacked crates</summary>
/// <remarks>Full RCON name: <c>clan.scoreforopeninghackedcrates</c></remarks>
public sealed class ClanScoreforopeninghackedcratesCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "clan.scoreforopeninghackedcrates";

    /// <summary>Reads the current value of <c>clan.scoreforopeninghackedcrates</c>.</summary>
    public static ClanScoreforopeninghackedcratesCommand CreateGet()
    {
        var cmd = CreatePackage<ClanScoreforopeninghackedcratesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>clan.scoreforopeninghackedcrates</c> to <paramref name="value"/>.</summary>
    public static ClanScoreforopeninghackedcratesCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ClanScoreforopeninghackedcratesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
