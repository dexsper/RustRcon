using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Returns the network protocol identifier string the server is currently using; clients must match this to connect</summary>
/// <remarks>Full RCON name: <c>server.netprotocol</c></remarks>
public sealed class ServerNetprotocolCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.netprotocol";

    /// <summary>Creates a new <see cref="ServerNetprotocolCommand"/> command.</summary>
    public static ServerNetprotocolCommand Create()
    {
        var cmd = CreatePackage<ServerNetprotocolCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
