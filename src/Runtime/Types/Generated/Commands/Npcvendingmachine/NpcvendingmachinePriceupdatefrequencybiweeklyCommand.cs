using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many realtime hours are checked when looking for price increases. Max 72 (10 days), min 0.5 (half an hour)</summary>
/// <remarks>Full RCON name: <c>npcvendingmachine.priceupdatefrequencybiweekly</c></remarks>
public sealed class NpcvendingmachinePriceupdatefrequencybiweeklyCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "npcvendingmachine.priceupdatefrequencybiweekly";

    /// <summary>Reads the current value of <c>npcvendingmachine.priceupdatefrequencybiweekly</c>.</summary>
    public static NpcvendingmachinePriceupdatefrequencybiweeklyCommand CreateGet()
    {
        var cmd = CreatePackage<NpcvendingmachinePriceupdatefrequencybiweeklyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>npcvendingmachine.priceupdatefrequencybiweekly</c> to <paramref name="value"/>.</summary>
    public static NpcvendingmachinePriceupdatefrequencybiweeklyCommand CreateSet(float value)
    {
        var cmd = CreatePackage<NpcvendingmachinePriceupdatefrequencybiweeklyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
