using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much score players earn for running the excavator</summary>
/// <remarks>Full RCON name: <c>clan.scoreforrunningexcavator</c></remarks>
public sealed class ClanScoreforrunningexcavatorCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "clan.scoreforrunningexcavator";

    /// <summary>Reads the current value of <c>clan.scoreforrunningexcavator</c>.</summary>
    public static ClanScoreforrunningexcavatorCommand CreateGet()
    {
        var cmd = CreatePackage<ClanScoreforrunningexcavatorCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>clan.scoreforrunningexcavator</c> to <paramref name="value"/>.</summary>
    public static ClanScoreforrunningexcavatorCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ClanScoreforrunningexcavatorCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
