using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, logs all Nexus zone transfer and communication events to the server console; useful for debugging cross-server player transfers</summary>
/// <remarks>Full RCON name: <c>nexus.logging</c></remarks>
public sealed class NexusLoggingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.logging";

    /// <summary>Reads the current value of <c>nexus.logging</c>.</summary>
    public static NexusLoggingCommand CreateGet()
    {
        var cmd = CreatePackage<NexusLoggingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>nexus.logging</c> to <paramref name="value"/>.</summary>
    public static NexusLoggingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<NexusLoggingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
