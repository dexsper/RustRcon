using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Size of analytics events, in bytes, that we try to send off using the same task thread. To disable, set to -1</summary>
/// <remarks>Full RCON name: <c>analytics.small_buffer_send_limit</c></remarks>
public sealed class AnalyticsSmallBufferSendLimitCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.small_buffer_send_limit";

    /// <summary>Reads the current value of <c>analytics.small_buffer_send_limit</c>.</summary>
    public static AnalyticsSmallBufferSendLimitCommand CreateGet()
    {
        var cmd = CreatePackage<AnalyticsSmallBufferSendLimitCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>analytics.small_buffer_send_limit</c> to <paramref name="value"/>.</summary>
    public static AnalyticsSmallBufferSendLimitCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AnalyticsSmallBufferSendLimitCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
