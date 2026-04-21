using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Header key of secret when uploading analytics</summary>
/// <remarks>Full RCON name: <c>analytics.analytics_header</c></remarks>
public sealed class AnalyticsAnalyticsHeaderCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.analytics_header";

    /// <summary>Reads the current value of <c>analytics.analytics_header</c>.</summary>
    public static AnalyticsAnalyticsHeaderCommand CreateGet()
    {
        var cmd = CreatePackage<AnalyticsAnalyticsHeaderCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>analytics.analytics_header</c> to <paramref name="value"/>.</summary>
    public static AnalyticsAnalyticsHeaderCommand CreateSet(string value)
    {
        var cmd = CreatePackage<AnalyticsAnalyticsHeaderCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
