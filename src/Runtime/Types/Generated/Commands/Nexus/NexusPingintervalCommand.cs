using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Time in seconds to wait between server status pings</summary>
/// <remarks>Full RCON name: <c>nexus.pinginterval</c></remarks>
public sealed class NexusPingintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.pinginterval";

    /// <summary>Reads the current value of <c>nexus.pinginterval</c>.</summary>
    public static NexusPingintervalCommand CreateGet()
    {
        var cmd = CreatePackage<NexusPingintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>nexus.pinginterval</c> to <paramref name="value"/>.</summary>
    public static NexusPingintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<NexusPingintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
