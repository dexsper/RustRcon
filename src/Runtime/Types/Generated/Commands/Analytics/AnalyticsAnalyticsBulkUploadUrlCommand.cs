using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Azure blob container url + SAS token, enables a more efficient upload method</summary>
/// <remarks>Full RCON name: <c>analytics.analytics_bulk_upload_url</c></remarks>
public sealed class AnalyticsAnalyticsBulkUploadUrlCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.analytics_bulk_upload_url";

    /// <summary>Reads the current value of <c>analytics.analytics_bulk_upload_url</c>.</summary>
    public static AnalyticsAnalyticsBulkUploadUrlCommand CreateGet()
    {
        var cmd = CreatePackage<AnalyticsAnalyticsBulkUploadUrlCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>analytics.analytics_bulk_upload_url</c> to <paramref name="value"/>.</summary>
    public static AnalyticsAnalyticsBulkUploadUrlCommand CreateSet(string value)
    {
        var cmd = CreatePackage<AnalyticsAnalyticsBulkUploadUrlCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
