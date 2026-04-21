using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, the ping estimator collects latency samples to regional servers; disable to suppress background ping traffic</summary>
/// <remarks>Full RCON name: <c>ping.ping_estimation</c></remarks>
public sealed class PingPingEstimationCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ping.ping_estimation";

    /// <summary>Reads the current value of <c>ping.ping_estimation</c>.</summary>
    public static PingPingEstimationCommand CreateGet()
    {
        var cmd = CreatePackage<PingPingEstimationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ping.ping_estimation</c> to <paramref name="value"/>.</summary>
    public static PingPingEstimationCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PingPingEstimationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
