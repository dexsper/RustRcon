using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>server.motd</c>.</summary>
/// <remarks>Full RCON name: <c>server.motd</c></remarks>
public sealed class ServerMotdCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.motd";

    /// <summary>Reads the current value of <c>server.motd</c>.</summary>
    public static ServerMotdCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMotdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.motd</c> to <paramref name="value"/>.</summary>
    public static ServerMotdCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerMotdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
