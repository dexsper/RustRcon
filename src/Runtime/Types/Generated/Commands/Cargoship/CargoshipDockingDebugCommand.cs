using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>cargoship.docking_debug</c>.</summary>
/// <remarks>Full RCON name: <c>cargoship.docking_debug</c></remarks>
public sealed class CargoshipDockingDebugCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cargoship.docking_debug";

    /// <summary>Reads the current value of <c>cargoship.docking_debug</c>.</summary>
    public static CargoshipDockingDebugCommand CreateGet()
    {
        var cmd = CreatePackage<CargoshipDockingDebugCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>cargoship.docking_debug</c> to <paramref name="value"/>.</summary>
    public static CargoshipDockingDebugCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<CargoshipDockingDebugCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
