using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>cargoship.cargo_escape_boat_rhib</c>.</summary>
/// <remarks>Full RCON name: <c>cargoship.cargo_escape_boat_rhib</c></remarks>
public sealed class CargoshipCargoEscapeBoatRhibCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cargoship.cargo_escape_boat_rhib";

    /// <summary>Reads the current value of <c>cargoship.cargo_escape_boat_rhib</c>.</summary>
    public static CargoshipCargoEscapeBoatRhibCommand CreateGet()
    {
        var cmd = CreatePackage<CargoshipCargoEscapeBoatRhibCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>cargoship.cargo_escape_boat_rhib</c> to <paramref name="value"/>.</summary>
    public static CargoshipCargoEscapeBoatRhibCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<CargoshipCargoEscapeBoatRhibCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
