using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Writes config files</summary>
/// <remarks>Full RCON name: <c>server.writecfg</c></remarks>
public sealed class ServerWritecfgCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.writecfg";

    /// <summary>Creates a new <see cref="ServerWritecfgCommand"/> command.</summary>
    public static ServerWritecfgCommand Create()
    {
        var cmd = CreatePackage<ServerWritecfgCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
