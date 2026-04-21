using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum byte size of a single console command packet from a client; oversized packets are rejected</summary>
/// <remarks>Full RCON name: <c>server.maxpacketsize_command</c></remarks>
public sealed class ServerMaxpacketsizeCommandCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxpacketsize_command";

    /// <summary>Reads the current value of <c>server.maxpacketsize_command</c>.</summary>
    public static ServerMaxpacketsizeCommandCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxpacketsizeCommandCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxpacketsize_command</c> to <paramref name="value"/>.</summary>
    public static ServerMaxpacketsizeCommandCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxpacketsizeCommandCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
