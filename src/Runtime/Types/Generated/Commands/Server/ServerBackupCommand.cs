using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Backup server folder</summary>
/// <remarks>Full RCON name: <c>server.backup</c></remarks>
public sealed class ServerBackupCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.backup";

    /// <summary>Creates a new <see cref="ServerBackupCommand"/> command.</summary>
    public static ServerBackupCommand Create()
    {
        var cmd = CreatePackage<ServerBackupCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
