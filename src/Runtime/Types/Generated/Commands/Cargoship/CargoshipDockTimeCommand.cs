using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>cargoship.dock_time</c>.</summary>
/// <remarks>Full RCON name: <c>cargoship.dock_time</c></remarks>
public sealed class CargoshipDockTimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cargoship.dock_time";

    /// <summary>Reads the current value of <c>cargoship.dock_time</c>.</summary>
    public static CargoshipDockTimeCommand CreateGet()
    {
        var cmd = CreatePackage<CargoshipDockTimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>cargoship.dock_time</c> to <paramref name="value"/>.</summary>
    public static CargoshipDockTimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<CargoshipDockTimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
