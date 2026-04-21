using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, items are kept in a reclaim backpack even if the player died while inside their own authorised base</summary>
/// <remarks>Full RCON name: <c>gamemodesoftcore.reclaim_building_auth</c></remarks>
public sealed class GamemodesoftcoreReclaimBuildingAuthCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "gamemodesoftcore.reclaim_building_auth";

    /// <summary>Reads the current value of <c>gamemodesoftcore.reclaim_building_auth</c>.</summary>
    public static GamemodesoftcoreReclaimBuildingAuthCommand CreateGet()
    {
        var cmd = CreatePackage<GamemodesoftcoreReclaimBuildingAuthCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>gamemodesoftcore.reclaim_building_auth</c> to <paramref name="value"/>.</summary>
    public static GamemodesoftcoreReclaimBuildingAuthCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<GamemodesoftcoreReclaimBuildingAuthCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
