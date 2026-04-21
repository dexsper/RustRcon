using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, ownership tracking is applied to stackable items; disabled by default due to performance cost; servers can enable for full ownership auditing</summary>
/// <remarks>Full RCON name: <c>inventory.stackable_item_ownership</c></remarks>
public sealed class InventoryStackableItemOwnershipCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "inventory.stackable_item_ownership";

    /// <summary>Reads the current value of <c>inventory.stackable_item_ownership</c>.</summary>
    public static InventoryStackableItemOwnershipCommand CreateGet()
    {
        var cmd = CreatePackage<InventoryStackableItemOwnershipCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>inventory.stackable_item_ownership</c> to <paramref name="value"/>.</summary>
    public static InventoryStackableItemOwnershipCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<InventoryStackableItemOwnershipCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
