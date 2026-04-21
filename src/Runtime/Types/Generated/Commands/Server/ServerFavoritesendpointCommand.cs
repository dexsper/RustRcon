using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Domain name to save when players favorite your server. The port can be omitted if using the default port or a SRV DNS record is created.</summary>
/// <remarks>Full RCON name: <c>server.favoritesendpoint</c></remarks>
public sealed class ServerFavoritesendpointCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.favoritesendpoint";

    /// <summary>Reads the current value of <c>server.favoritesendpoint</c>.</summary>
    public static ServerFavoritesendpointCommand CreateGet()
    {
        var cmd = CreatePackage<ServerFavoritesendpointCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.favoritesendpoint</c> to <paramref name="value"/>.</summary>
    public static ServerFavoritesendpointCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerFavoritesendpointCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
