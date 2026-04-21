using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_cover_path_vs_straight_dist_max_diff defines what the maximum difference between straight-line distance and path distance can be when evaluating cover points. (default: 2)</summary>
/// <remarks>Full RCON name: <c>ai.npc_cover_path_vs_straight_dist_max_diff</c></remarks>
public sealed class AiNpcCoverPathVsStraightDistMaxDiffCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_cover_path_vs_straight_dist_max_diff";

    /// <summary>Reads the current value of <c>ai.npc_cover_path_vs_straight_dist_max_diff</c>.</summary>
    public static AiNpcCoverPathVsStraightDistMaxDiffCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcCoverPathVsStraightDistMaxDiffCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_cover_path_vs_straight_dist_max_diff</c> to <paramref name="value"/>.</summary>
    public static AiNpcCoverPathVsStraightDistMaxDiffCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcCoverPathVsStraightDistMaxDiffCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
