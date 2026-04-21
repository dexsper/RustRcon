using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Toggle whether gameplay rpc logging is collected</summary>
/// <remarks>Full RCON name: <c>analytics.gameplay_rpc_analytics</c></remarks>
public sealed class AnalyticsGameplayRpcAnalyticsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.gameplay_rpc_analytics";

    /// <summary>Reads the current value of <c>analytics.gameplay_rpc_analytics</c>.</summary>
    public static AnalyticsGameplayRpcAnalyticsCommand CreateGet()
    {
        var cmd = CreatePackage<AnalyticsGameplayRpcAnalyticsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>analytics.gameplay_rpc_analytics</c> to <paramref name="value"/>.</summary>
    public static AnalyticsGameplayRpcAnalyticsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AnalyticsGameplayRpcAnalyticsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
