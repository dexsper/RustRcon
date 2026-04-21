using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the current server outgoing network write queue depth (packet count and total byte size)</summary>
/// <remarks>Full RCON name: <c>server.printwritequeue</c></remarks>
public sealed class ServerPrintwritequeueCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.printwritequeue";

    /// <summary>Creates a new <see cref="ServerPrintwritequeueCommand"/> command.</summary>
    public static ServerPrintwritequeueCommand Create()
    {
        var cmd = CreatePackage<ServerPrintwritequeueCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
