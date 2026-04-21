using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>analytics.server_analytics_url</c>.</summary>
/// <remarks>Full RCON name: <c>analytics.server_analytics_url</c></remarks>
public sealed class AnalyticsServerAnalyticsUrlCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.server_analytics_url";

    /// <summary>Reads the current value of <c>analytics.server_analytics_url</c>.</summary>
    public static AnalyticsServerAnalyticsUrlCommand CreateGet()
    {
        var cmd = CreatePackage<AnalyticsServerAnalyticsUrlCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>analytics.server_analytics_url</c> to <paramref name="value"/>.</summary>
    public static AnalyticsServerAnalyticsUrlCommand CreateSet(string value)
    {
        var cmd = CreatePackage<AnalyticsServerAnalyticsUrlCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
