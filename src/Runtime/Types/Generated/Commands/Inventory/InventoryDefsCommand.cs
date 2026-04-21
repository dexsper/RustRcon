using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the names of all Steam inventory item definitions currently loaded from the Steam backend; useful for verifying skin/item definition state</summary>
/// <remarks>Full RCON name: <c>inventory.defs</c></remarks>
public sealed class InventoryDefsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "inventory.defs";

    /// <summary>Creates a new <see cref="InventoryDefsCommand"/> command.</summary>
    public static InventoryDefsCommand Create()
    {
        var cmd = CreatePackage<InventoryDefsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
