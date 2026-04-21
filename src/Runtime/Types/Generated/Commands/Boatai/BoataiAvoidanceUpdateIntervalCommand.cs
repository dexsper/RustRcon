using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How often to update the avoidance cache. Lower number means a more accurate cache at the expensive of performance.</summary>
/// <remarks>Full RCON name: <c>boatai.avoidance_update_interval</c></remarks>
public sealed class BoataiAvoidanceUpdateIntervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatai.avoidance_update_interval";

    /// <summary>Reads the current value of <c>boatai.avoidance_update_interval</c>.</summary>
    public static BoataiAvoidanceUpdateIntervalCommand CreateGet()
    {
        var cmd = CreatePackage<BoataiAvoidanceUpdateIntervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatai.avoidance_update_interval</c> to <paramref name="value"/>.</summary>
    public static BoataiAvoidanceUpdateIntervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BoataiAvoidanceUpdateIntervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
