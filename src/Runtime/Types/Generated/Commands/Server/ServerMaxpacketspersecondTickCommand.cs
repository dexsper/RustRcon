using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum tick-update packets per second accepted from each client; these carry player inputs and must stay within this rate to be processed</summary>
/// <remarks>Full RCON name: <c>server.maxpacketspersecond_tick</c></remarks>
public sealed class ServerMaxpacketspersecondTickCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxpacketspersecond_tick";

    /// <summary>Reads the current value of <c>server.maxpacketspersecond_tick</c>.</summary>
    public static ServerMaxpacketspersecondTickCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxpacketspersecondTickCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxpacketspersecond_tick</c> to <paramref name="value"/>.</summary>
    public static ServerMaxpacketspersecondTickCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxpacketspersecondTickCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
