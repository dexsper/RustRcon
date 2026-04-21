using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Get info on player corpses on the server</summary>
/// <remarks>Full RCON name: <c>server.corpseinfo</c></remarks>
public sealed class ServerCorpseinfoCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.corpseinfo";

    /// <summary>Creates a new <see cref="ServerCorpseinfoCommand"/> command.</summary>
    public static ServerCorpseinfoCommand Create()
    {
        var cmd = CreatePackage<ServerCorpseinfoCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
