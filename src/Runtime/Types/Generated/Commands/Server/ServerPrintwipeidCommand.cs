using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Prints the current wipe id of the sav</summary>
/// <remarks>Full RCON name: <c>server.printwipeid</c></remarks>
public sealed class ServerPrintwipeidCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.printwipeid";

    /// <summary>Creates a new <see cref="ServerPrintwipeidCommand"/> command.</summary>
    public static ServerPrintwipeidCommand Create()
    {
        var cmd = CreatePackage<ServerPrintwipeidCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
