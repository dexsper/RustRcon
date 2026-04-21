using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Minutes of in-game inactivity before a player is automatically kicked; set to 0 to disable idle kick</summary>
/// <remarks>Full RCON name: <c>server.idlekick</c></remarks>
public sealed class ServerIdlekickCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.idlekick";

    /// <summary>Reads the current value of <c>server.idlekick</c>.</summary>
    public static ServerIdlekickCommand CreateGet()
    {
        var cmd = CreatePackage<ServerIdlekickCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.idlekick</c> to <paramref name="value"/>.</summary>
    public static ServerIdlekickCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerIdlekickCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
