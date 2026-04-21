using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many realtime hours are checked when looking for price increases. Max 72 (10 days), min 0.5 (half an hour)</summary>
/// <remarks>Full RCON name: <c>npcvendingmachine.priceupdatefrequencyweekly</c></remarks>
public sealed class NpcvendingmachinePriceupdatefrequencyweeklyCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "npcvendingmachine.priceupdatefrequencyweekly";

    /// <summary>Reads the current value of <c>npcvendingmachine.priceupdatefrequencyweekly</c>.</summary>
    public static NpcvendingmachinePriceupdatefrequencyweeklyCommand CreateGet()
    {
        var cmd = CreatePackage<NpcvendingmachinePriceupdatefrequencyweeklyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>npcvendingmachine.priceupdatefrequencyweekly</c> to <paramref name="value"/>.</summary>
    public static NpcvendingmachinePriceupdatefrequencyweeklyCommand CreateSet(float value)
    {
        var cmd = CreatePackage<NpcvendingmachinePriceupdatefrequencyweeklyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
