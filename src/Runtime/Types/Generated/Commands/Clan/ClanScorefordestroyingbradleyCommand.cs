using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much score players earn for destroying bradley</summary>
/// <remarks>Full RCON name: <c>clan.scorefordestroyingbradley</c></remarks>
public sealed class ClanScorefordestroyingbradleyCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "clan.scorefordestroyingbradley";

    /// <summary>Reads the current value of <c>clan.scorefordestroyingbradley</c>.</summary>
    public static ClanScorefordestroyingbradleyCommand CreateGet()
    {
        var cmd = CreatePackage<ClanScorefordestroyingbradleyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>clan.scorefordestroyingbradley</c> to <paramref name="value"/>.</summary>
    public static ClanScorefordestroyingbradleyCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ClanScorefordestroyingbradleyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
