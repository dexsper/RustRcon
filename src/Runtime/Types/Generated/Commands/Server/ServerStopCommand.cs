using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Stops a server</summary>
/// <remarks>Full RCON name: <c>server.stop</c></remarks>
public sealed class ServerStopCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.stop";

    /// <summary>Creates a new <see cref="ServerStopCommand"/> command.</summary>
    public static ServerStopCommand Create(string args)
    {
        var cmd = CreatePackage<ServerStopCommand>();
        cmd.Content = $"{CommandFullName} {args}";
        return cmd;
    }
}
