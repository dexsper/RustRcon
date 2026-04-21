using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Forces a reload of all Steam inventory item definitions from the Steam backend; use if definitions appear stale or missing after a store update</summary>
/// <remarks>Full RCON name: <c>inventory.reloaddefs</c></remarks>
public sealed class InventoryReloaddefsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "inventory.reloaddefs";

    /// <summary>Creates a new <see cref="InventoryReloaddefsCommand"/> command.</summary>
    public static InventoryReloaddefsCommand Create()
    {
        var cmd = CreatePackage<InventoryReloaddefsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
