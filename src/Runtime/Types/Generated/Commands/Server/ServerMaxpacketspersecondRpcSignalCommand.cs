using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum RPC signal packets per second accepted from each client; signal RPCs are lightweight event triggers used for interactions</summary>
/// <remarks>Full RCON name: <c>server.maxpacketspersecond_rpc_signal</c></remarks>
public sealed class ServerMaxpacketspersecondRpcSignalCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxpacketspersecond_rpc_signal";

    /// <summary>Reads the current value of <c>server.maxpacketspersecond_rpc_signal</c>.</summary>
    public static ServerMaxpacketspersecondRpcSignalCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxpacketspersecondRpcSignalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxpacketspersecond_rpc_signal</c> to <paramref name="value"/>.</summary>
    public static ServerMaxpacketspersecondRpcSignalCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxpacketspersecondRpcSignalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
