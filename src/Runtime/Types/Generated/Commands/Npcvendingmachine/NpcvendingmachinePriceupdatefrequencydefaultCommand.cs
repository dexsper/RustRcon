using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many realtime hours are checked when looking for price increases. Max 72 (10 days), min 0.5 (half an hour)</summary>
/// <remarks>Full RCON name: <c>npcvendingmachine.priceupdatefrequencydefault</c></remarks>
public sealed class NpcvendingmachinePriceupdatefrequencydefaultCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "npcvendingmachine.priceupdatefrequencydefault";

    /// <summary>Reads the current value of <c>npcvendingmachine.priceupdatefrequencydefault</c>.</summary>
    public static NpcvendingmachinePriceupdatefrequencydefaultCommand CreateGet()
    {
        var cmd = CreatePackage<NpcvendingmachinePriceupdatefrequencydefaultCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>npcvendingmachine.priceupdatefrequencydefault</c> to <paramref name="value"/>.</summary>
    public static NpcvendingmachinePriceupdatefrequencydefaultCommand CreateSet(float value)
    {
        var cmd = CreatePackage<NpcvendingmachinePriceupdatefrequencydefaultCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
