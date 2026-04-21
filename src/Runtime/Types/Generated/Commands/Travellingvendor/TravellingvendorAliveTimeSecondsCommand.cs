using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum lifetime in seconds before the Travelling Vendor despawns; default 1800s (30 minutes)</summary>
/// <remarks>Full RCON name: <c>travellingvendor.alive_time_seconds</c></remarks>
public sealed class TravellingvendorAliveTimeSecondsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "travellingvendor.alive_time_seconds";

    /// <summary>Reads the current value of <c>travellingvendor.alive_time_seconds</c>.</summary>
    public static TravellingvendorAliveTimeSecondsCommand CreateGet()
    {
        var cmd = CreatePackage<TravellingvendorAliveTimeSecondsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>travellingvendor.alive_time_seconds</c> to <paramref name="value"/>.</summary>
    public static TravellingvendorAliveTimeSecondsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<TravellingvendorAliveTimeSecondsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
