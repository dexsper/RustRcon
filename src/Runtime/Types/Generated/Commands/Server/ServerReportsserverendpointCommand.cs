using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>HTTP API endpoint for receiving F7 reports</summary>
/// <remarks>Full RCON name: <c>server.reportsserverendpoint</c></remarks>
public sealed class ServerReportsserverendpointCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.reportsserverendpoint";

    /// <summary>Reads the current value of <c>server.reportsserverendpoint</c>.</summary>
    public static ServerReportsserverendpointCommand CreateGet()
    {
        var cmd = CreatePackage<ServerReportsserverendpointCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.reportsserverendpoint</c> to <paramref name="value"/>.</summary>
    public static ServerReportsserverendpointCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerReportsserverendpointCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
