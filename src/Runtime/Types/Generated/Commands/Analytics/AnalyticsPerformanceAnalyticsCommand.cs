using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Toggle to turn off server performance collection</summary>
/// <remarks>Full RCON name: <c>analytics.performance_analytics</c></remarks>
public sealed class AnalyticsPerformanceAnalyticsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.performance_analytics";

    /// <summary>Reads the current value of <c>analytics.performance_analytics</c>.</summary>
    public static AnalyticsPerformanceAnalyticsCommand CreateGet()
    {
        var cmd = CreatePackage<AnalyticsPerformanceAnalyticsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>analytics.performance_analytics</c> to <paramref name="value"/>.</summary>
    public static AnalyticsPerformanceAnalyticsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AnalyticsPerformanceAnalyticsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
