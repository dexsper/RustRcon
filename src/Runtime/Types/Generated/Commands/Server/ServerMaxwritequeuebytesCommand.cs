using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum total byte size of the outgoing write queue; if the queue fills the oldest packets are dropped</summary>
/// <remarks>Full RCON name: <c>server.maxwritequeuebytes</c></remarks>
public sealed class ServerMaxwritequeuebytesCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxwritequeuebytes";

    /// <summary>Reads the current value of <c>server.maxwritequeuebytes</c>.</summary>
    public static ServerMaxwritequeuebytesCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxwritequeuebytesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxwritequeuebytes</c> to <paramref name="value"/>.</summary>
    public static ServerMaxwritequeuebytesCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxwritequeuebytesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
