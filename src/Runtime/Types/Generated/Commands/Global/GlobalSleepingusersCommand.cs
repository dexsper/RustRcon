using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Show user info for players on server.</summary>
/// <remarks>Full RCON name: <c>global.sleepingusers</c></remarks>
public sealed class GlobalSleepingusersCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.sleepingusers";

    /// <summary>Creates a new <see cref="GlobalSleepingusersCommand"/> command.</summary>
    public static GlobalSleepingusersCommand Create()
    {
        var cmd = CreatePackage<GlobalSleepingusersCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
