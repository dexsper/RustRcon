using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Toggle whether gameplay analytics is collected</summary>
/// <remarks>Full RCON name: <c>analytics.gameplay_analytics</c></remarks>
public sealed class AnalyticsGameplayAnalyticsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.gameplay_analytics";

    /// <summary>Reads the current value of <c>analytics.gameplay_analytics</c>.</summary>
    public static AnalyticsGameplayAnalyticsCommand CreateGet()
    {
        var cmd = CreatePackage<AnalyticsGameplayAnalyticsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>analytics.gameplay_analytics</c> to <paramref name="value"/>.</summary>
    public static AnalyticsGameplayAnalyticsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AnalyticsGameplayAnalyticsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
