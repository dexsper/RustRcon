using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) UDP port the server listens on for player connections</summary>
/// <remarks>Full RCON name: <c>server.port</c></remarks>
public sealed class ServerPortCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.port";

    /// <summary>Reads the current value of <c>server.port</c>.</summary>
    public static ServerPortCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPortCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.port</c> to <paramref name="value"/>.</summary>
    public static ServerPortCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerPortCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
