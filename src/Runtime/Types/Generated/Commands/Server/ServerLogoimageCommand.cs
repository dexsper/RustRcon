using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) URL of the logo image shown for this server in the server browser</summary>
/// <remarks>Full RCON name: <c>server.logoimage</c></remarks>
public sealed class ServerLogoimageCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.logoimage";

    /// <summary>Reads the current value of <c>server.logoimage</c>.</summary>
    public static ServerLogoimageCommand CreateGet()
    {
        var cmd = CreatePackage<ServerLogoimageCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.logoimage</c> to <paramref name="value"/>.</summary>
    public static ServerLogoimageCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerLogoimageCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
