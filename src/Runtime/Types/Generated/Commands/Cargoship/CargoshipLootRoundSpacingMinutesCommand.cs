using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>cargoship.loot_round_spacing_minutes</c>.</summary>
/// <remarks>Full RCON name: <c>cargoship.loot_round_spacing_minutes</c></remarks>
public sealed class CargoshipLootRoundSpacingMinutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cargoship.loot_round_spacing_minutes";

    /// <summary>Reads the current value of <c>cargoship.loot_round_spacing_minutes</c>.</summary>
    public static CargoshipLootRoundSpacingMinutesCommand CreateGet()
    {
        var cmd = CreatePackage<CargoshipLootRoundSpacingMinutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>cargoship.loot_round_spacing_minutes</c> to <paramref name="value"/>.</summary>
    public static CargoshipLootRoundSpacingMinutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<CargoshipLootRoundSpacingMinutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
