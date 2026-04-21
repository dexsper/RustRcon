using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When true the server sends the map file to clients so they can load it without re-generating it locally</summary>
/// <remarks>Full RCON name: <c>server.leveltransfer</c></remarks>
public sealed class ServerLeveltransferCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.leveltransfer";

    /// <summary>Reads the current value of <c>server.leveltransfer</c>.</summary>
    public static ServerLeveltransferCommand CreateGet()
    {
        var cmd = CreatePackage<ServerLeveltransferCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.leveltransfer</c> to <paramref name="value"/>.</summary>
    public static ServerLeveltransferCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerLeveltransferCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
