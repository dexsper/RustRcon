using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Should the in-game map be covered by a fog of war</summary>
/// <remarks>Full RCON name: <c>server.fogofwar</c></remarks>
public sealed class ServerFogofwarCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.fogofwar";

    /// <summary>Reads the current value of <c>server.fogofwar</c>.</summary>
    public static ServerFogofwarCommand CreateGet()
    {
        var cmd = CreatePackage<ServerFogofwarCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.fogofwar</c> to <paramref name="value"/>.</summary>
    public static ServerFogofwarCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerFogofwarCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
