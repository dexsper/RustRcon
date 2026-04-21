using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of ping samples collected per estimation cycle; more samples give a more accurate average latency but take longer to complete</summary>
/// <remarks>Full RCON name: <c>ping.ping_samples</c></remarks>
public sealed class PingPingSamplesCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ping.ping_samples";

    /// <summary>Reads the current value of <c>ping.ping_samples</c>.</summary>
    public static PingPingSamplesCommand CreateGet()
    {
        var cmd = CreatePackage<PingPingSamplesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ping.ping_samples</c> to <paramref name="value"/>.</summary>
    public static PingPingSamplesCommand CreateSet(int value)
    {
        var cmd = CreatePackage<PingPingSamplesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
