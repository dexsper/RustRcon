using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much to increase time to kill in pvp globally, 2.0 = twice as long, 0.5 = half as long</summary>
/// <remarks>Full RCON name: <c>server.pvp_ttk_global</c></remarks>
public sealed class ServerPvpTtkGlobalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.pvp_ttk_global";

    /// <summary>Reads the current value of <c>server.pvp_ttk_global</c>.</summary>
    public static ServerPvpTtkGlobalCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPvpTtkGlobalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.pvp_ttk_global</c> to <paramref name="value"/>.</summary>
    public static ServerPvpTtkGlobalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerPvpTtkGlobalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
