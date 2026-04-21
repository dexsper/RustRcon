using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Rescans the serveremoji folder, note that clients will need to reconnect to get the latest emoji</summary>
/// <remarks>Full RCON name: <c>server.resetserveremoji</c></remarks>
public sealed class ServerResetserveremojiCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.resetserveremoji";

    /// <summary>Creates a new <see cref="ServerResetserveremojiCommand"/> command.</summary>
    public static ServerResetserveremojiCommand Create()
    {
        var cmd = CreatePackage<ServerResetserveremojiCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
