using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Enables RPC call logging; must be true before the rpclog command will return data. Tracks how often each RPC is called</summary>
/// <remarks>Full RCON name: <c>server.rpclog_enabled</c></remarks>
public sealed class ServerRpclogEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.rpclog_enabled";

    /// <summary>Reads the current value of <c>server.rpclog_enabled</c>.</summary>
    public static ServerRpclogEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<ServerRpclogEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.rpclog_enabled</c> to <paramref name="value"/>.</summary>
    public static ServerRpclogEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerRpclogEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
