using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much to increase time to kill bullets in pvp globally, 2.0 = twice as long, 0.5 = half as long</summary>
/// <remarks>Full RCON name: <c>server.pvp_ttk_bullet</c></remarks>
public sealed class ServerPvpTtkBulletCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.pvp_ttk_bullet";

    /// <summary>Reads the current value of <c>server.pvp_ttk_bullet</c>.</summary>
    public static ServerPvpTtkBulletCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPvpTtkBulletCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.pvp_ttk_bullet</c> to <paramref name="value"/>.</summary>
    public static ServerPvpTtkBulletCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerPvpTtkBulletCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
