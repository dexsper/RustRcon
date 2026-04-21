using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, the puzzle reset timer pauses for monuments that have not been looted yet, preventing resets of untouched areas</summary>
/// <remarks>Full RCON name: <c>server.pauseunlootedpuzzles</c></remarks>
public sealed class ServerPauseunlootedpuzzlesCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.pauseunlootedpuzzles";

    /// <summary>Reads the current value of <c>server.pauseunlootedpuzzles</c>.</summary>
    public static ServerPauseunlootedpuzzlesCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPauseunlootedpuzzlesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.pauseunlootedpuzzles</c> to <paramref name="value"/>.</summary>
    public static ServerPauseunlootedpuzzlesCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerPauseunlootedpuzzlesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
