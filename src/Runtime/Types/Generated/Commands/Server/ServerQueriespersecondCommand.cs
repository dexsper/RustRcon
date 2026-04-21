using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of Steam server browser queries the server will respond to per second before rate-limiting</summary>
/// <remarks>Full RCON name: <c>server.queriespersecond</c></remarks>
public sealed class ServerQueriespersecondCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.queriespersecond";

    /// <summary>Reads the current value of <c>server.queriespersecond</c>.</summary>
    public static ServerQueriespersecondCommand CreateGet()
    {
        var cmd = CreatePackage<ServerQueriespersecondCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.queriespersecond</c> to <paramref name="value"/>.</summary>
    public static ServerQueriespersecondCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerQueriespersecondCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
