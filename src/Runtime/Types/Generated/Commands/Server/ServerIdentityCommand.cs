using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Unique identifier for this server instance; determines the subfolder used for saves, configs and map data</summary>
/// <remarks>Full RCON name: <c>server.identity</c></remarks>
public sealed class ServerIdentityCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.identity";

    /// <summary>Reads the current value of <c>server.identity</c>.</summary>
    public static ServerIdentityCommand CreateGet()
    {
        var cmd = CreatePackage<ServerIdentityCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.identity</c> to <paramref name="value"/>.</summary>
    public static ServerIdentityCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerIdentityCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
