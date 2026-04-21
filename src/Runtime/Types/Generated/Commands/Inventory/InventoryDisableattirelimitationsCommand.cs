using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Disables all attire limitations, so NPC clothing and invalid overlaps can be equipped</summary>
/// <remarks>Full RCON name: <c>inventory.disableattirelimitations</c></remarks>
public sealed class InventoryDisableattirelimitationsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "inventory.disableattirelimitations";

    /// <summary>Reads the current value of <c>inventory.disableattirelimitations</c>.</summary>
    public static InventoryDisableattirelimitationsCommand CreateGet()
    {
        var cmd = CreatePackage<InventoryDisableattirelimitationsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>inventory.disableattirelimitations</c> to <paramref name="value"/>.</summary>
    public static InventoryDisableattirelimitationsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<InventoryDisableattirelimitationsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
