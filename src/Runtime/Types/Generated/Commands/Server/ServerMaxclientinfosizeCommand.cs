using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum byte size of the client info blob sent during the connection handshake; clients sending a larger payload are rejected</summary>
/// <remarks>Full RCON name: <c>server.maxclientinfosize</c></remarks>
public sealed class ServerMaxclientinfosizeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxclientinfosize";

    /// <summary>Reads the current value of <c>server.maxclientinfosize</c>.</summary>
    public static ServerMaxclientinfosizeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxclientinfosizeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxclientinfosize</c> to <paramref name="value"/>.</summary>
    public static ServerMaxclientinfosizeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxclientinfosizeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
