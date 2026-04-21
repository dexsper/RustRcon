using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much to increase time to kill with melee in pvp globally, 2.0 = twice as long, 0.5 = half as long</summary>
/// <remarks>Full RCON name: <c>server.pvp_ttk_melee</c></remarks>
public sealed class ServerPvpTtkMeleeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.pvp_ttk_melee";

    /// <summary>Reads the current value of <c>server.pvp_ttk_melee</c>.</summary>
    public static ServerPvpTtkMeleeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPvpTtkMeleeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.pvp_ttk_melee</c> to <paramref name="value"/>.</summary>
    public static ServerPvpTtkMeleeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerPvpTtkMeleeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
