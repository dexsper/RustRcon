using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Interval in minutes between automatic background ping estimation refreshes for server list region latency sorting</summary>
/// <remarks>Full RCON name: <c>ping.ping_refresh_interval</c></remarks>
public sealed class PingPingRefreshIntervalCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ping.ping_refresh_interval";

    /// <summary>Reads the current value of <c>ping.ping_refresh_interval</c>.</summary>
    public static PingPingRefreshIntervalCommand CreateGet()
    {
        var cmd = CreatePackage<PingPingRefreshIntervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ping.ping_refresh_interval</c> to <paramref name="value"/>.</summary>
    public static PingPingRefreshIntervalCommand CreateSet(int value)
    {
        var cmd = CreatePackage<PingPingRefreshIntervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
