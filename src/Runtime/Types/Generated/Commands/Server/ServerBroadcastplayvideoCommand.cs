using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Sends a video URL to all connected players, causing the in-game video player to open and play the specified video on every client</summary>
/// <remarks>Full RCON name: <c>server.broadcastplayvideo</c></remarks>
public sealed class ServerBroadcastplayvideoCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.broadcastplayvideo";

    /// <summary>Creates a new <see cref="ServerBroadcastplayvideoCommand"/> command.</summary>
    public static ServerBroadcastplayvideoCommand Create(string args)
    {
        var cmd = CreatePackage<ServerBroadcastplayvideoCommand>();
        cmd.Content = $"{CommandFullName} {args}";
        return cmd;
    }
}
