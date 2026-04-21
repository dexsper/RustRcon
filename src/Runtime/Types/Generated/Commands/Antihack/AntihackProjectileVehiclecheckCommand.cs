using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.projectile_vehiclecheck</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.projectile_vehiclecheck</c></remarks>
public sealed class AntihackProjectileVehiclecheckCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.projectile_vehiclecheck";

    /// <summary>Reads the current value of <c>antihack.projectile_vehiclecheck</c>.</summary>
    public static AntihackProjectileVehiclecheckCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackProjectileVehiclecheckCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.projectile_vehiclecheck</c> to <paramref name="value"/>.</summary>
    public static AntihackProjectileVehiclecheckCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackProjectileVehiclecheckCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
