using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Seconds before environmental debris entities (e.g. broken barrel remnants) are removed from the world; default 30 seconds</summary>
/// <remarks>Full RCON name: <c>server.debrisdespawn</c></remarks>
public sealed class ServerDebrisdespawnCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.debrisdespawn";

    /// <summary>Reads the current value of <c>server.debrisdespawn</c>.</summary>
    public static ServerDebrisdespawnCommand CreateGet()
    {
        var cmd = CreatePackage<ServerDebrisdespawnCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.debrisdespawn</c> to <paramref name="value"/>.</summary>
    public static ServerDebrisdespawnCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerDebrisdespawnCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
