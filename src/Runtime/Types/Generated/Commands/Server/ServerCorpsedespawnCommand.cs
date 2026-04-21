using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Seconds before a player corpse is removed from the world; default is 300 seconds (5 minutes)</summary>
/// <remarks>Full RCON name: <c>server.corpsedespawn</c></remarks>
public sealed class ServerCorpsedespawnCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.corpsedespawn";

    /// <summary>Reads the current value of <c>server.corpsedespawn</c>.</summary>
    public static ServerCorpsedespawnCommand CreateGet()
    {
        var cmd = CreatePackage<ServerCorpsedespawnCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.corpsedespawn</c> to <paramref name="value"/>.</summary>
    public static ServerCorpsedespawnCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerCorpsedespawnCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
