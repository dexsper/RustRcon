using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much to decrease the price for if it is underselling (0.05 = 5%)</summary>
/// <remarks>Full RCON name: <c>npcvendingmachine.pricedecreaseamount</c></remarks>
public sealed class NpcvendingmachinePricedecreaseamountCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "npcvendingmachine.pricedecreaseamount";

    /// <summary>Reads the current value of <c>npcvendingmachine.pricedecreaseamount</c>.</summary>
    public static NpcvendingmachinePricedecreaseamountCommand CreateGet()
    {
        var cmd = CreatePackage<NpcvendingmachinePricedecreaseamountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>npcvendingmachine.pricedecreaseamount</c> to <paramref name="value"/>.</summary>
    public static NpcvendingmachinePricedecreaseamountCommand CreateSet(float value)
    {
        var cmd = CreatePackage<NpcvendingmachinePricedecreaseamountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
