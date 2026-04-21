using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>vehicle.boat_corpse_seconds</c>.</summary>
/// <remarks>Full RCON name: <c>vehicle.boat_corpse_seconds</c></remarks>
public sealed class VehicleBoatCorpseSecondsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vehicle.boat_corpse_seconds";

    /// <summary>Reads the current value of <c>vehicle.boat_corpse_seconds</c>.</summary>
    public static VehicleBoatCorpseSecondsCommand CreateGet()
    {
        var cmd = CreatePackage<VehicleBoatCorpseSecondsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vehicle.boat_corpse_seconds</c> to <paramref name="value"/>.</summary>
    public static VehicleBoatCorpseSecondsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<VehicleBoatCorpseSecondsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
