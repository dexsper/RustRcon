using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Fraction of belt slot items that are preserved in a softcore death reclaim backpack; default 0.5 (50%)</summary>
/// <remarks>Full RCON name: <c>gamemodesoftcore.reclaim_fraction_belt</c></remarks>
public sealed class GamemodesoftcoreReclaimFractionBeltCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "gamemodesoftcore.reclaim_fraction_belt";

    /// <summary>Reads the current value of <c>gamemodesoftcore.reclaim_fraction_belt</c>.</summary>
    public static GamemodesoftcoreReclaimFractionBeltCommand CreateGet()
    {
        var cmd = CreatePackage<GamemodesoftcoreReclaimFractionBeltCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>gamemodesoftcore.reclaim_fraction_belt</c> to <paramref name="value"/>.</summary>
    public static GamemodesoftcoreReclaimFractionBeltCommand CreateSet(float value)
    {
        var cmd = CreatePackage<GamemodesoftcoreReclaimFractionBeltCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
