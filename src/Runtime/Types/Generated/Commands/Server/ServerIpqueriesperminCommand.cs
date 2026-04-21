using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of Steam server browser queries allowed per minute from a single IP address</summary>
/// <remarks>Full RCON name: <c>server.ipqueriespermin</c></remarks>
public sealed class ServerIpqueriesperminCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.ipqueriespermin";

    /// <summary>Reads the current value of <c>server.ipqueriespermin</c>.</summary>
    public static ServerIpqueriesperminCommand CreateGet()
    {
        var cmd = CreatePackage<ServerIpqueriesperminCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.ipqueriespermin</c> to <paramref name="value"/>.</summary>
    public static ServerIpqueriesperminCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerIpqueriesperminCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
