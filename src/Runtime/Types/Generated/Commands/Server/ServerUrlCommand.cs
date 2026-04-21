using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Server website URL displayed in the server browser; leave empty to show no link</summary>
/// <remarks>Full RCON name: <c>server.url</c></remarks>
public sealed class ServerUrlCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.url";

    /// <summary>Reads the current value of <c>server.url</c>.</summary>
    public static ServerUrlCommand CreateGet()
    {
        var cmd = CreatePackage<ServerUrlCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.url</c> to <paramref name="value"/>.</summary>
    public static ServerUrlCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerUrlCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
