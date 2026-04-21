using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Fraction of main inventory items preserved in a softcore death reclaim backpack; default 0.5 (50%)</summary>
/// <remarks>Full RCON name: <c>gamemodesoftcore.reclaim_fraction_main</c></remarks>
public sealed class GamemodesoftcoreReclaimFractionMainCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "gamemodesoftcore.reclaim_fraction_main";

    /// <summary>Reads the current value of <c>gamemodesoftcore.reclaim_fraction_main</c>.</summary>
    public static GamemodesoftcoreReclaimFractionMainCommand CreateGet()
    {
        var cmd = CreatePackage<GamemodesoftcoreReclaimFractionMainCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>gamemodesoftcore.reclaim_fraction_main</c> to <paramref name="value"/>.</summary>
    public static GamemodesoftcoreReclaimFractionMainCommand CreateSet(float value)
    {
        var cmd = CreatePackage<GamemodesoftcoreReclaimFractionMainCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
