using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>cargoship.loot_rounds</c>.</summary>
/// <remarks>Full RCON name: <c>cargoship.loot_rounds</c></remarks>
public sealed class CargoshipLootRoundsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cargoship.loot_rounds";

    /// <summary>Reads the current value of <c>cargoship.loot_rounds</c>.</summary>
    public static CargoshipLootRoundsCommand CreateGet()
    {
        var cmd = CreatePackage<CargoshipLootRoundsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>cargoship.loot_rounds</c> to <paramref name="value"/>.</summary>
    public static CargoshipLootRoundsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<CargoshipLootRoundsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
