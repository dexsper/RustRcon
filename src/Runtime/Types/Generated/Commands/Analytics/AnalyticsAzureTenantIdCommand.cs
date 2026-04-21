using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Azure tenant id for authentication</summary>
/// <remarks>Full RCON name: <c>analytics.azure_tenant_id</c></remarks>
public sealed class AnalyticsAzureTenantIdCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.azure_tenant_id";

    /// <summary>Reads the current value of <c>analytics.azure_tenant_id</c>.</summary>
    public static AnalyticsAzureTenantIdCommand CreateGet()
    {
        var cmd = CreatePackage<AnalyticsAzureTenantIdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>analytics.azure_tenant_id</c> to <paramref name="value"/>.</summary>
    public static AnalyticsAzureTenantIdCommand CreateSet(string value)
    {
        var cmd = CreatePackage<AnalyticsAzureTenantIdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
