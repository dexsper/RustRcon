using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>cargoship.refresh_loot_on_dock</c>.</summary>
/// <remarks>Full RCON name: <c>cargoship.refresh_loot_on_dock</c></remarks>
public sealed class CargoshipRefreshLootOnDockCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cargoship.refresh_loot_on_dock";

    /// <summary>Reads the current value of <c>cargoship.refresh_loot_on_dock</c>.</summary>
    public static CargoshipRefreshLootOnDockCommand CreateGet()
    {
        var cmd = CreatePackage<CargoshipRefreshLootOnDockCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>cargoship.refresh_loot_on_dock</c> to <paramref name="value"/>.</summary>
    public static CargoshipRefreshLootOnDockCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<CargoshipRefreshLootOnDockCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
