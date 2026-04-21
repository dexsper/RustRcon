using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Azure client secret for authentication</summary>
/// <remarks>Full RCON name: <c>analytics.azure_client_secret</c></remarks>
public sealed class AnalyticsAzureClientSecretCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.azure_client_secret";

    /// <summary>Reads the current value of <c>analytics.azure_client_secret</c>.</summary>
    public static AnalyticsAzureClientSecretCommand CreateGet()
    {
        var cmd = CreatePackage<AnalyticsAzureClientSecretCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>analytics.azure_client_secret</c> to <paramref name="value"/>.</summary>
    public static AnalyticsAzureClientSecretCommand CreateSet(string value)
    {
        var cmd = CreatePackage<AnalyticsAzureClientSecretCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
