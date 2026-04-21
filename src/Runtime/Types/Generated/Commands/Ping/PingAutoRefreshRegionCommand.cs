using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, region ping estimates are automatically refreshed in the background to keep server list latency data up to date</summary>
/// <remarks>Full RCON name: <c>ping.auto_refresh_region</c></remarks>
public sealed class PingAutoRefreshRegionCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ping.auto_refresh_region";

    /// <summary>Reads the current value of <c>ping.auto_refresh_region</c>.</summary>
    public static PingAutoRefreshRegionCommand CreateGet()
    {
        var cmd = CreatePackage<PingAutoRefreshRegionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ping.auto_refresh_region</c> to <paramref name="value"/>.</summary>
    public static PingAutoRefreshRegionCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PingAutoRefreshRegionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
