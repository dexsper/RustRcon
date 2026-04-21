using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Resets the state of all discounts and surcharges from NPC vending machines</summary>
/// <remarks>Full RCON name: <c>npcvendingmachine.resetdynamicpricing</c></remarks>
public sealed class NpcvendingmachineResetdynamicpricingCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "npcvendingmachine.resetdynamicpricing";

    /// <summary>Creates a new <see cref="NpcvendingmachineResetdynamicpricingCommand"/> command.</summary>
    public static NpcvendingmachineResetdynamicpricingCommand Create()
    {
        var cmd = CreatePackage<NpcvendingmachineResetdynamicpricingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
