using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, radiation-contaminated water damages loot containers over time when exposed to sufficient radiation</summary>
/// <remarks>Full RCON name: <c>radiation.water_loot_damage</c></remarks>
public sealed class RadiationWaterLootDamageCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "radiation.water_loot_damage";

    /// <summary>Reads the current value of <c>radiation.water_loot_damage</c>.</summary>
    public static RadiationWaterLootDamageCommand CreateGet()
    {
        var cmd = CreatePackage<RadiationWaterLootDamageCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>radiation.water_loot_damage</c> to <paramref name="value"/>.</summary>
    public static RadiationWaterLootDamageCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<RadiationWaterLootDamageCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
