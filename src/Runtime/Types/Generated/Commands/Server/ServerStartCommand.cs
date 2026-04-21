using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Starts a server</summary>
/// <remarks>Full RCON name: <c>server.start</c></remarks>
public sealed class ServerStartCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.start";

    /// <summary>Creates a new <see cref="ServerStartCommand"/> command.</summary>
    public static ServerStartCommand Create(string strLevelName)
    {
        var cmd = CreatePackage<ServerStartCommand>();
        cmd.Content = $"{CommandFullName} {strLevelName}";
        return cmd;
    }
}
