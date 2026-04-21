using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Shows how many analytics events are pending upload</summary>
/// <remarks>Full RCON name: <c>analytics.pending_analytics</c></remarks>
public sealed class AnalyticsPendingAnalyticsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.pending_analytics";

    /// <summary>Creates a new <see cref="AnalyticsPendingAnalyticsCommand"/> command.</summary>
    public static AnalyticsPendingAnalyticsCommand Create()
    {
        var cmd = CreatePackage<AnalyticsPendingAnalyticsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
