using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Send network update for all players</summary>
/// <remarks>Full RCON name: <c>server.sendnetworkupdate</c></remarks>
public sealed class ServerSendnetworkupdateCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.sendnetworkupdate";

    /// <summary>Creates a new <see cref="ServerSendnetworkupdateCommand"/> command.</summary>
    public static ServerSendnetworkupdateCommand Create()
    {
        var cmd = CreatePackage<ServerSendnetworkupdateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
