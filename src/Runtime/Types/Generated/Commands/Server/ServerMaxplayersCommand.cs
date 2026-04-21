using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of players allowed on the server at the same time</summary>
/// <remarks>Full RCON name: <c>server.maxplayers</c></remarks>
public sealed class ServerMaxplayersCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxplayers";

    /// <summary>Reads the current value of <c>server.maxplayers</c>.</summary>
    public static ServerMaxplayersCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxplayersCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxplayers</c> to <paramref name="value"/>.</summary>
    public static ServerMaxplayersCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxplayersCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
