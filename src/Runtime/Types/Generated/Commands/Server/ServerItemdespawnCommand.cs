using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Seconds before items dropped on the ground despawn; default is 300 seconds (5 minutes)</summary>
/// <remarks>Full RCON name: <c>server.itemdespawn</c></remarks>
public sealed class ServerItemdespawnCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.itemdespawn";

    /// <summary>Reads the current value of <c>server.itemdespawn</c>.</summary>
    public static ServerItemdespawnCommand CreateGet()
    {
        var cmd = CreatePackage<ServerItemdespawnCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.itemdespawn</c> to <paramref name="value"/>.</summary>
    public static ServerItemdespawnCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerItemdespawnCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
