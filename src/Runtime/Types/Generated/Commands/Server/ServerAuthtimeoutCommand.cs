using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Seconds an incoming connection has to complete authentication (Steam + EAC) before being forcibly disconnected</summary>
/// <remarks>Full RCON name: <c>server.authtimeout</c></remarks>
public sealed class ServerAuthtimeoutCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.authtimeout";

    /// <summary>Reads the current value of <c>server.authtimeout</c>.</summary>
    public static ServerAuthtimeoutCommand CreateGet()
    {
        var cmd = CreatePackage<ServerAuthtimeoutCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.authtimeout</c> to <paramref name="value"/>.</summary>
    public static ServerAuthtimeoutCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerAuthtimeoutCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
