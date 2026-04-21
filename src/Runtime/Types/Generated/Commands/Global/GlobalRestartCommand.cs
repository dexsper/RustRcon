using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Schedules a server restart; optionally accepts a countdown in seconds and a broadcast message sent to all players before the restart occurs</summary>
/// <remarks>Full RCON name: <c>global.restart</c></remarks>
public sealed class GlobalRestartCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.restart";

    /// <summary>Creates a new <see cref="GlobalRestartCommand"/> command.</summary>
    public static GlobalRestartCommand Create()
    {
        var cmd = CreatePackage<GlobalRestartCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
