using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Azure client id for authentication</summary>
/// <remarks>Full RCON name: <c>analytics.azure_client_id</c></remarks>
public sealed class AnalyticsAzureClientIdCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.azure_client_id";

    /// <summary>Reads the current value of <c>analytics.azure_client_id</c>.</summary>
    public static AnalyticsAzureClientIdCommand CreateGet()
    {
        var cmd = CreatePackage<AnalyticsAzureClientIdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>analytics.azure_client_id</c> to <paramref name="value"/>.</summary>
    public static AnalyticsAzureClientIdCommand CreateSet(string value)
    {
        var cmd = CreatePackage<AnalyticsAzureClientIdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
