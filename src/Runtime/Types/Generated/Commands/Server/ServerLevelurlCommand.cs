using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) URL to download a custom map file from; if set the server will fetch and load this map instead of generating one</summary>
/// <remarks>Full RCON name: <c>server.levelurl</c></remarks>
public sealed class ServerLevelurlCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.levelurl";

    /// <summary>Reads the current value of <c>server.levelurl</c>.</summary>
    public static ServerLevelurlCommand CreateGet()
    {
        var cmd = CreatePackage<ServerLevelurlCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.levelurl</c> to <paramref name="value"/>.</summary>
    public static ServerLevelurlCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerLevelurlCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
