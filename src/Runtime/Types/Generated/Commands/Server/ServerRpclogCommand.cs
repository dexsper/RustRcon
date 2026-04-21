using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a sorted table of RPC identifiers, their string names, and cumulative call counts; requires rpclog_enabled = true</summary>
/// <remarks>Full RCON name: <c>server.rpclog</c></remarks>
public sealed class ServerRpclogCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.rpclog";

    /// <summary>Creates a new <see cref="ServerRpclogCommand"/> command.</summary>
    public static ServerRpclogCommand Create()
    {
        var cmd = CreatePackage<ServerRpclogCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
