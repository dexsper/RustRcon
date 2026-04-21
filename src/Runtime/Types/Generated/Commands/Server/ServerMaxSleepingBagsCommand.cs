using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>server.max_sleeping_bags</c>.</summary>
/// <remarks>Full RCON name: <c>server.max_sleeping_bags</c></remarks>
public sealed class ServerMaxSleepingBagsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.max_sleeping_bags";

    /// <summary>Reads the current value of <c>server.max_sleeping_bags</c>.</summary>
    public static ServerMaxSleepingBagsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxSleepingBagsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.max_sleeping_bags</c> to <paramref name="value"/>.</summary>
    public static ServerMaxSleepingBagsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxSleepingBagsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
