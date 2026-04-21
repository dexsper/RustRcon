using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, items are kept in a reclaim backpack even if the player died by suicide (F1 kill)</summary>
/// <remarks>Full RCON name: <c>gamemodesoftcore.reclaim_suicide</c></remarks>
public sealed class GamemodesoftcoreReclaimSuicideCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "gamemodesoftcore.reclaim_suicide";

    /// <summary>Reads the current value of <c>gamemodesoftcore.reclaim_suicide</c>.</summary>
    public static GamemodesoftcoreReclaimSuicideCommand CreateGet()
    {
        var cmd = CreatePackage<GamemodesoftcoreReclaimSuicideCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>gamemodesoftcore.reclaim_suicide</c> to <paramref name="value"/>.</summary>
    public static GamemodesoftcoreReclaimSuicideCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<GamemodesoftcoreReclaimSuicideCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
