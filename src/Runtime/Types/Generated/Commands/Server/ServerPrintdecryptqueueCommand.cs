using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>server.printdecryptqueue</c>.</summary>
/// <remarks>Full RCON name: <c>server.printdecryptqueue</c></remarks>
public sealed class ServerPrintdecryptqueueCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.printdecryptqueue";

    /// <summary>Creates a new <see cref="ServerPrintdecryptqueueCommand"/> command.</summary>
    public static ServerPrintdecryptqueueCommand Create()
    {
        var cmd = CreatePackage<ServerPrintdecryptqueueCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
