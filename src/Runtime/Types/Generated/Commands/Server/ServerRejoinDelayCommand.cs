using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Seconds a disconnected player must wait before they are allowed to rejoin the server; default is 300 seconds (5 minutes)</summary>
/// <remarks>Full RCON name: <c>server.rejoin_delay</c></remarks>
public sealed class ServerRejoinDelayCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.rejoin_delay";

    /// <summary>Reads the current value of <c>server.rejoin_delay</c>.</summary>
    public static ServerRejoinDelayCommand CreateGet()
    {
        var cmd = CreatePackage<ServerRejoinDelayCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.rejoin_delay</c> to <paramref name="value"/>.</summary>
    public static ServerRejoinDelayCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerRejoinDelayCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
