using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Azure blob container url for use with client secret authentication</summary>
/// <remarks>Full RCON name: <c>analytics.analytics_bulk_container_url</c></remarks>
public sealed class AnalyticsAnalyticsBulkContainerUrlCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.analytics_bulk_container_url";

    /// <summary>Reads the current value of <c>analytics.analytics_bulk_container_url</c>.</summary>
    public static AnalyticsAnalyticsBulkContainerUrlCommand CreateGet()
    {
        var cmd = CreatePackage<AnalyticsAnalyticsBulkContainerUrlCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>analytics.analytics_bulk_container_url</c> to <paramref name="value"/>.</summary>
    public static AnalyticsAnalyticsBulkContainerUrlCommand CreateSet(string value)
    {
        var cmd = CreatePackage<AnalyticsAnalyticsBulkContainerUrlCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
