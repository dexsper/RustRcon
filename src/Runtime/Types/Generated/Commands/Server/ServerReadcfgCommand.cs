using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Reads and executes serverauto.cfg then server.cfg from the server's cfg folder, applying all saved convar values</summary>
/// <remarks>Full RCON name: <c>server.readcfg</c></remarks>
public sealed class ServerReadcfgCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.readcfg";

    /// <summary>Creates a new <see cref="ServerReadcfgCommand"/> command.</summary>
    public static ServerReadcfgCommand Create()
    {
        var cmd = CreatePackage<ServerReadcfgCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
