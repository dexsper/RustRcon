using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, radiation-contaminated water damages items in a player's inventory over time when in a radiation zone</summary>
/// <remarks>Full RCON name: <c>radiation.water_inventory_damage</c></remarks>
public sealed class RadiationWaterInventoryDamageCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "radiation.water_inventory_damage";

    /// <summary>Reads the current value of <c>radiation.water_inventory_damage</c>.</summary>
    public static RadiationWaterInventoryDamageCommand CreateGet()
    {
        var cmd = CreatePackage<RadiationWaterInventoryDamageCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>radiation.water_inventory_damage</c> to <paramref name="value"/>.</summary>
    public static RadiationWaterInventoryDamageCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<RadiationWaterInventoryDamageCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
