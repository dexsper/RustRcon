using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Force save the current game</summary>
/// <remarks>Full RCON name: <c>server.save</c></remarks>
public sealed class ServerSaveCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.save";

    /// <summary>Creates a new <see cref="ServerSaveCommand"/> command.</summary>
    public static ServerSaveCommand Create()
    {
        var cmd = CreatePackage<ServerSaveCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
