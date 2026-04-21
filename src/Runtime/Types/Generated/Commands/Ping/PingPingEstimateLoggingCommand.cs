using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, logs ping estimation results to the console; useful for debugging regional latency measurement accuracy</summary>
/// <remarks>Full RCON name: <c>ping.ping_estimate_logging</c></remarks>
public sealed class PingPingEstimateLoggingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ping.ping_estimate_logging";

    /// <summary>Reads the current value of <c>ping.ping_estimate_logging</c>.</summary>
    public static PingPingEstimateLoggingCommand CreateGet()
    {
        var cmd = CreatePackage<PingPingEstimateLoggingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ping.ping_estimate_logging</c> to <paramref name="value"/>.</summary>
    public static PingPingEstimateLoggingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PingPingEstimateLoggingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
