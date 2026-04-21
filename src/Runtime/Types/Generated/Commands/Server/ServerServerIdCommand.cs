using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Persistent unique identifier for this server instance, used when recording demos and for analytics attribution</summary>
/// <remarks>Full RCON name: <c>server.server_id</c></remarks>
public sealed class ServerServerIdCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.server_id";

    /// <summary>Reads the current value of <c>server.server_id</c>.</summary>
    public static ServerServerIdCommand CreateGet()
    {
        var cmd = CreatePackage<ServerServerIdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.server_id</c> to <paramref name="value"/>.</summary>
    public static ServerServerIdCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerServerIdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
