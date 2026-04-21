using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum RPC (Remote Procedure Call) packets per second accepted from each client; limits how fast clients can trigger server-side actions</summary>
/// <remarks>Full RCON name: <c>server.maxpacketspersecond_rpc</c></remarks>
public sealed class ServerMaxpacketspersecondRpcCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxpacketspersecond_rpc";

    /// <summary>Reads the current value of <c>server.maxpacketspersecond_rpc</c>.</summary>
    public static ServerMaxpacketspersecondRpcCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxpacketspersecondRpcCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxpacketspersecond_rpc</c> to <paramref name="value"/>.</summary>
    public static ServerMaxpacketspersecondRpcCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxpacketspersecondRpcCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
