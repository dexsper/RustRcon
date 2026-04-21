using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum sync-var (replicated variable) update packets per second accepted from each client</summary>
/// <remarks>Full RCON name: <c>server.maxpacketspersecond_syncvar</c></remarks>
public sealed class ServerMaxpacketspersecondSyncvarCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxpacketspersecond_syncvar";

    /// <summary>Reads the current value of <c>server.maxpacketspersecond_syncvar</c>.</summary>
    public static ServerMaxpacketspersecondSyncvarCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxpacketspersecondSyncvarCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxpacketspersecond_syncvar</c> to <paramref name="value"/>.</summary>
    public static ServerMaxpacketspersecondSyncvarCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxpacketspersecondSyncvarCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
