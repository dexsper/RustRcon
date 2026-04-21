using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the current server incoming network read queue depth (packet count and total byte size)</summary>
/// <remarks>Full RCON name: <c>server.printreadqueue</c></remarks>
public sealed class ServerPrintreadqueueCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.printreadqueue";

    /// <summary>Creates a new <see cref="ServerPrintreadqueueCommand"/> command.</summary>
    public static ServerPrintreadqueueCommand Create()
    {
        var cmd = CreatePackage<ServerPrintreadqueueCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
