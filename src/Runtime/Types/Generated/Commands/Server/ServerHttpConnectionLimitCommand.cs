using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of simultaneous outbound HTTP connections the server may have open at once; used for map uploads, ban checks, and other web requests</summary>
/// <remarks>Full RCON name: <c>server.http_connection_limit</c></remarks>
public sealed class ServerHttpConnectionLimitCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.http_connection_limit";

    /// <summary>Reads the current value of <c>server.http_connection_limit</c>.</summary>
    public static ServerHttpConnectionLimitCommand CreateGet()
    {
        var cmd = CreatePackage<ServerHttpConnectionLimitCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.http_connection_limit</c> to <paramref name="value"/>.</summary>
    public static ServerHttpConnectionLimitCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerHttpConnectionLimitCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
