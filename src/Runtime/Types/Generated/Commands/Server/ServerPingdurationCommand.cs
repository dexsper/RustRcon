using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long a ping should last</summary>
/// <remarks>Full RCON name: <c>server.pingduration</c></remarks>
public sealed class ServerPingdurationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.pingduration";

    /// <summary>Reads the current value of <c>server.pingduration</c>.</summary>
    public static ServerPingdurationCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPingdurationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.pingduration</c> to <paramref name="value"/>.</summary>
    public static ServerPingdurationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerPingdurationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
