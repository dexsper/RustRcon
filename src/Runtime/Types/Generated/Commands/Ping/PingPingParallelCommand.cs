using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, ping estimation sends samples to all servers in parallel for faster results; uses more bandwidth simultaneously</summary>
/// <remarks>Full RCON name: <c>ping.ping_parallel</c></remarks>
public sealed class PingPingParallelCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ping.ping_parallel";

    /// <summary>Reads the current value of <c>ping.ping_parallel</c>.</summary>
    public static PingPingParallelCommand CreateGet()
    {
        var cmd = CreatePackage<PingPingParallelCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ping.ping_parallel</c> to <paramref name="value"/>.</summary>
    public static PingPingParallelCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PingPingParallelCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
