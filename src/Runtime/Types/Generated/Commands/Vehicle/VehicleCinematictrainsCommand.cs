using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If true, trains always explode when destroyed, and hitting a barrier always destroys the train immediately. Default: false</summary>
/// <remarks>Full RCON name: <c>vehicle.cinematictrains</c></remarks>
public sealed class VehicleCinematictrainsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vehicle.cinematictrains";

    /// <summary>Reads the current value of <c>vehicle.cinematictrains</c>.</summary>
    public static VehicleCinematictrainsCommand CreateGet()
    {
        var cmd = CreatePackage<VehicleCinematictrainsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vehicle.cinematictrains</c> to <paramref name="value"/>.</summary>
    public static VehicleCinematictrainsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<VehicleCinematictrainsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
