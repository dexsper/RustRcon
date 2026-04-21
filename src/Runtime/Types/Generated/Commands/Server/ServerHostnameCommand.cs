using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Server name displayed in the server browser</summary>
/// <remarks>Full RCON name: <c>server.hostname</c></remarks>
public sealed class ServerHostnameCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.hostname";

    /// <summary>Reads the current value of <c>server.hostname</c>.</summary>
    public static ServerHostnameCommand CreateGet()
    {
        var cmd = CreatePackage<ServerHostnameCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.hostname</c> to <paramref name="value"/>.</summary>
    public static ServerHostnameCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerHostnameCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
