using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Toggle whether gameplay tick analytics is collected</summary>
/// <remarks>Full RCON name: <c>analytics.gameplay_tick_analytics</c></remarks>
public sealed class AnalyticsGameplayTickAnalyticsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.gameplay_tick_analytics";

    /// <summary>Reads the current value of <c>analytics.gameplay_tick_analytics</c>.</summary>
    public static AnalyticsGameplayTickAnalyticsCommand CreateGet()
    {
        var cmd = CreatePackage<AnalyticsGameplayTickAnalyticsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>analytics.gameplay_tick_analytics</c> to <paramref name="value"/>.</summary>
    public static AnalyticsGameplayTickAnalyticsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AnalyticsGameplayTickAnalyticsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
