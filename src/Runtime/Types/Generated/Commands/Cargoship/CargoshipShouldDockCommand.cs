using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>cargoship.should_dock</c>.</summary>
/// <remarks>Full RCON name: <c>cargoship.should_dock</c></remarks>
public sealed class CargoshipShouldDockCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cargoship.should_dock";

    /// <summary>Reads the current value of <c>cargoship.should_dock</c>.</summary>
    public static CargoshipShouldDockCommand CreateGet()
    {
        var cmd = CreatePackage<CargoshipShouldDockCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>cargoship.should_dock</c> to <paramref name="value"/>.</summary>
    public static CargoshipShouldDockCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<CargoshipShouldDockCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
