using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) URL of the banner/header image shown at the top of this server's page in the server browser</summary>
/// <remarks>Full RCON name: <c>server.headerimage</c></remarks>
public sealed class ServerHeaderimageCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.headerimage";

    /// <summary>Reads the current value of <c>server.headerimage</c>.</summary>
    public static ServerHeaderimageCommand CreateGet()
    {
        var cmd = CreatePackage<ServerHeaderimageCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.headerimage</c> to <paramref name="value"/>.</summary>
    public static ServerHeaderimageCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerHeaderimageCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
