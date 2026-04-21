using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long a race can go until it times out (in seconds)</summary>
/// <remarks>Full RCON name: <c>waypointrace.racetimeout</c></remarks>
public sealed class WaypointraceRacetimeoutCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "waypointrace.racetimeout";

    /// <summary>Reads the current value of <c>waypointrace.racetimeout</c>.</summary>
    public static WaypointraceRacetimeoutCommand CreateGet()
    {
        var cmd = CreatePackage<WaypointraceRacetimeoutCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>waypointrace.racetimeout</c> to <paramref name="value"/>.</summary>
    public static WaypointraceRacetimeoutCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WaypointraceRacetimeoutCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
