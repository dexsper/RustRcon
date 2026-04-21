using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Fast-despawn time in seconds used for short-lived dropped items such as empty casings or small debris; default 30 seconds</summary>
/// <remarks>Full RCON name: <c>server.itemdespawn_quick</c></remarks>
public sealed class ServerItemdespawnQuickCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.itemdespawn_quick";

    /// <summary>Reads the current value of <c>server.itemdespawn_quick</c>.</summary>
    public static ServerItemdespawnQuickCommand CreateGet()
    {
        var cmd = CreatePackage<ServerItemdespawnQuickCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.itemdespawn_quick</c> to <paramref name="value"/>.</summary>
    public static ServerItemdespawnQuickCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerItemdespawnQuickCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
