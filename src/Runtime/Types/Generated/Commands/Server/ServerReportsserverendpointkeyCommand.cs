using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If set, this key will be included with any reports sent via reportsServerEndpoint (for validation)</summary>
/// <remarks>Full RCON name: <c>server.reportsserverendpointkey</c></remarks>
public sealed class ServerReportsserverendpointkeyCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.reportsserverendpointkey";

    /// <summary>Reads the current value of <c>server.reportsserverendpointkey</c>.</summary>
    public static ServerReportsserverendpointkeyCommand CreateGet()
    {
        var cmd = CreatePackage<ServerReportsserverendpointkeyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.reportsserverendpointkey</c> to <paramref name="value"/>.</summary>
    public static ServerReportsserverendpointkeyCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerReportsserverendpointkeyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
