using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Global cap on total network packets per second the server will accept across all connected clients combined</summary>
/// <remarks>Full RCON name: <c>server.maxpacketspersecond</c></remarks>
public sealed class ServerMaxpacketspersecondCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxpacketspersecond";

    /// <summary>Reads the current value of <c>server.maxpacketspersecond</c>.</summary>
    public static ServerMaxpacketspersecondCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxpacketspersecondCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxpacketspersecond</c> to <paramref name="value"/>.</summary>
    public static ServerMaxpacketspersecondCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxpacketspersecondCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
