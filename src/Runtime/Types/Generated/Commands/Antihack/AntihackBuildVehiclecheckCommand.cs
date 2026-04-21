using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.build_vehiclecheck</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.build_vehiclecheck</c></remarks>
public sealed class AntihackBuildVehiclecheckCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.build_vehiclecheck";

    /// <summary>Reads the current value of <c>antihack.build_vehiclecheck</c>.</summary>
    public static AntihackBuildVehiclecheckCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackBuildVehiclecheckCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.build_vehiclecheck</c> to <paramref name="value"/>.</summary>
    public static AntihackBuildVehiclecheckCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackBuildVehiclecheckCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
