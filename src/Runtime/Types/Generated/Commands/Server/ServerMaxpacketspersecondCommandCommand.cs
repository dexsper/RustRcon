using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum console command packets per second accepted from each client; rate-limits how quickly clients can send commands to the server</summary>
/// <remarks>Full RCON name: <c>server.maxpacketspersecond_command</c></remarks>
public sealed class ServerMaxpacketspersecondCommandCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxpacketspersecond_command";

    /// <summary>Reads the current value of <c>server.maxpacketspersecond_command</c>.</summary>
    public static ServerMaxpacketspersecondCommandCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxpacketspersecondCommandCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxpacketspersecond_command</c> to <paramref name="value"/>.</summary>
    public static ServerMaxpacketspersecondCommandCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxpacketspersecondCommandCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
