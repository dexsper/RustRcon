using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the current server frame rate in frames per second</summary>
/// <remarks>Full RCON name: <c>server.fps</c></remarks>
public sealed class ServerFpsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.fps";

    /// <summary>Creates a new <see cref="ServerFpsCommand"/> command.</summary>
    public static ServerFpsCommand Create()
    {
        var cmd = CreatePackage<ServerFpsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
