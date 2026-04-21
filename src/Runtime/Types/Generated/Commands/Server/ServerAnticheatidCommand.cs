using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Easy Anti-Cheat product ID used to authenticate this server with EAC services</summary>
/// <remarks>Full RCON name: <c>server.anticheatid</c></remarks>
public sealed class ServerAnticheatidCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.anticheatid";

    /// <summary>Reads the current value of <c>server.anticheatid</c>.</summary>
    public static ServerAnticheatidCommand CreateGet()
    {
        var cmd = CreatePackage<ServerAnticheatidCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.anticheatid</c> to <paramref name="value"/>.</summary>
    public static ServerAnticheatidCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerAnticheatidCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
