using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.eye_vehiclecheck</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.eye_vehiclecheck</c></remarks>
public sealed class AntihackEyeVehiclecheckCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.eye_vehiclecheck";

    /// <summary>Reads the current value of <c>antihack.eye_vehiclecheck</c>.</summary>
    public static AntihackEyeVehiclecheckCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackEyeVehiclecheckCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.eye_vehiclecheck</c> to <paramref name="value"/>.</summary>
    public static AntihackEyeVehiclecheckCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackEyeVehiclecheckCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
