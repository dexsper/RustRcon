using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Fraction of clothing/armour items that are preserved in a softcore death reclaim backpack; default 1.0 (100%)</summary>
/// <remarks>Full RCON name: <c>gamemodesoftcore.reclaim_fraction_wear</c></remarks>
public sealed class GamemodesoftcoreReclaimFractionWearCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "gamemodesoftcore.reclaim_fraction_wear";

    /// <summary>Reads the current value of <c>gamemodesoftcore.reclaim_fraction_wear</c>.</summary>
    public static GamemodesoftcoreReclaimFractionWearCommand CreateGet()
    {
        var cmd = CreatePackage<GamemodesoftcoreReclaimFractionWearCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>gamemodesoftcore.reclaim_fraction_wear</c> to <paramref name="value"/>.</summary>
    public static GamemodesoftcoreReclaimFractionWearCommand CreateSet(float value)
    {
        var cmd = CreatePackage<GamemodesoftcoreReclaimFractionWearCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
