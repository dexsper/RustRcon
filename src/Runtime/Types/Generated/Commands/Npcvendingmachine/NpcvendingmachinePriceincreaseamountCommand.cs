using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much to increase the price by if it is selling a lot (0.05 = 5%)</summary>
/// <remarks>Full RCON name: <c>npcvendingmachine.priceincreaseamount</c></remarks>
public sealed class NpcvendingmachinePriceincreaseamountCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "npcvendingmachine.priceincreaseamount";

    /// <summary>Reads the current value of <c>npcvendingmachine.priceincreaseamount</c>.</summary>
    public static NpcvendingmachinePriceincreaseamountCommand CreateGet()
    {
        var cmd = CreatePackage<NpcvendingmachinePriceincreaseamountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>npcvendingmachine.priceincreaseamount</c> to <paramref name="value"/>.</summary>
    public static NpcvendingmachinePriceincreaseamountCommand CreateSet(float value)
    {
        var cmd = CreatePackage<NpcvendingmachinePriceincreaseamountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
