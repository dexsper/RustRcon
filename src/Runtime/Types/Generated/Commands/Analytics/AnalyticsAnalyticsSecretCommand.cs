using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Header secret value when uploading analytics</summary>
/// <remarks>Full RCON name: <c>analytics.analytics_secret</c></remarks>
public sealed class AnalyticsAnalyticsSecretCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.analytics_secret";

    /// <summary>Reads the current value of <c>analytics.analytics_secret</c>.</summary>
    public static AnalyticsAnalyticsSecretCommand CreateGet()
    {
        var cmd = CreatePackage<AnalyticsAnalyticsSecretCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>analytics.analytics_secret</c> to <paramref name="value"/>.</summary>
    public static AnalyticsAnalyticsSecretCommand CreateSet(string value)
    {
        var cmd = CreatePackage<AnalyticsAnalyticsSecretCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
