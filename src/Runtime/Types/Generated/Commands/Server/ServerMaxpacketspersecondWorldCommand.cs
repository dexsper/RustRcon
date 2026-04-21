using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum world-state update packets per second accepted from each individual client; prevents flooding the server with position spam</summary>
/// <remarks>Full RCON name: <c>server.maxpacketspersecond_world</c></remarks>
public sealed class ServerMaxpacketspersecondWorldCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxpacketspersecond_world";

    /// <summary>Reads the current value of <c>server.maxpacketspersecond_world</c>.</summary>
    public static ServerMaxpacketspersecondWorldCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxpacketspersecondWorldCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxpacketspersecond_world</c> to <paramref name="value"/>.</summary>
    public static ServerMaxpacketspersecondWorldCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxpacketspersecondWorldCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
