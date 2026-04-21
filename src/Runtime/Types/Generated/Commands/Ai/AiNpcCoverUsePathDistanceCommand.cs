using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If npc_cover_use_path_distance is set to true then npcs will look at the distance between the cover point and their target using the path between the two, rather than the straight-line distance.</summary>
/// <remarks>Full RCON name: <c>ai.npc_cover_use_path_distance</c></remarks>
public sealed class AiNpcCoverUsePathDistanceCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_cover_use_path_distance";

    /// <summary>Reads the current value of <c>ai.npc_cover_use_path_distance</c>.</summary>
    public static AiNpcCoverUsePathDistanceCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcCoverUsePathDistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_cover_use_path_distance</c> to <paramref name="value"/>.</summary>
    public static AiNpcCoverUsePathDistanceCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiNpcCoverUsePathDistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
