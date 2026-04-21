using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) IP address the server binds to; leave empty to bind to all interfaces</summary>
/// <remarks>Full RCON name: <c>server.ip</c></remarks>
public sealed class ServerIpCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.ip";

    /// <summary>Reads the current value of <c>server.ip</c>.</summary>
    public static ServerIpCommand CreateGet()
    {
        var cmd = CreatePackage<ServerIpCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.ip</c> to <paramref name="value"/>.</summary>
    public static ServerIpCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerIpCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
