using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Whether to run the the dynamic pricing system</summary>
/// <remarks>Full RCON name: <c>npcvendingmachine.dynamicpricingenabled</c></remarks>
public sealed class NpcvendingmachineDynamicpricingenabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "npcvendingmachine.dynamicpricingenabled";

    /// <summary>Reads the current value of <c>npcvendingmachine.dynamicpricingenabled</c>.</summary>
    public static NpcvendingmachineDynamicpricingenabledCommand CreateGet()
    {
        var cmd = CreatePackage<NpcvendingmachineDynamicpricingenabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>npcvendingmachine.dynamicpricingenabled</c> to <paramref name="value"/>.</summary>
    public static NpcvendingmachineDynamicpricingenabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<NpcvendingmachineDynamicpricingenabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
