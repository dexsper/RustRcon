using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.melee_vehiclecheck</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.melee_vehiclecheck</c></remarks>
public sealed class AntihackMeleeVehiclecheckCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.melee_vehiclecheck";

    /// <summary>Reads the current value of <c>antihack.melee_vehiclecheck</c>.</summary>
    public static AntihackMeleeVehiclecheckCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackMeleeVehiclecheckCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.melee_vehiclecheck</c> to <paramref name="value"/>.</summary>
    public static AntihackMeleeVehiclecheckCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackMeleeVehiclecheckCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
