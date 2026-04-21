using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>HTTP API endpoint for centralized banning (see wiki)</summary>
/// <remarks>Full RCON name: <c>server.bansserverendpoint</c></remarks>
public sealed class ServerBansserverendpointCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.bansserverendpoint";

    /// <summary>Reads the current value of <c>server.bansserverendpoint</c>.</summary>
    public static ServerBansserverendpointCommand CreateGet()
    {
        var cmd = CreatePackage<ServerBansserverendpointCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.bansserverendpoint</c> to <paramref name="value"/>.</summary>
    public static ServerBansserverendpointCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerBansserverendpointCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
