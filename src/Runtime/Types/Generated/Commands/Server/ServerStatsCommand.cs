using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Enables collection and reporting of gameplay statistics such as kill counts, damage dealt and resource gathered</summary>
/// <remarks>Full RCON name: <c>server.stats</c></remarks>
public sealed class ServerStatsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.stats";

    /// <summary>Reads the current value of <c>server.stats</c>.</summary>
    public static ServerStatsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerStatsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.stats</c> to <paramref name="value"/>.</summary>
    public static ServerStatsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerStatsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
