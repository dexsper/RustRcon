using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>analytics.stats</c>.</summary>
/// <remarks>Full RCON name: <c>analytics.stats</c></remarks>
public sealed class AnalyticsStatsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.stats";

    /// <summary>Creates a new <see cref="AnalyticsStatsCommand"/> command.</summary>
    public static AnalyticsStatsCommand Create()
    {
        var cmd = CreatePackage<AnalyticsStatsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
