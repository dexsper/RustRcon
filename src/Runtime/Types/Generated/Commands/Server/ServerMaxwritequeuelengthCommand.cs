using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of packets that can be queued in the outgoing write queue; excess packets are dropped when the queue is full</summary>
/// <remarks>Full RCON name: <c>server.maxwritequeuelength</c></remarks>
public sealed class ServerMaxwritequeuelengthCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxwritequeuelength";

    /// <summary>Reads the current value of <c>server.maxwritequeuelength</c>.</summary>
    public static ServerMaxwritequeuelengthCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxwritequeuelengthCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxwritequeuelength</c> to <paramref name="value"/>.</summary>
    public static ServerMaxwritequeuelengthCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxwritequeuelengthCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
