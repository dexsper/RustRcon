using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Reassigns ownership of a sleeping bag (by entity ID) to the calling player; notifies both the old and new owner</summary>
/// <remarks>Full RCON name: <c>sleepingbag.assigntoplayer</c></remarks>
public sealed class SleepingbagAssigntoplayerCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "sleepingbag.assigntoplayer";

    /// <summary>Creates a new <see cref="SleepingbagAssigntoplayerCommand"/> command.</summary>
    public static SleepingbagAssigntoplayerCommand Create()
    {
        var cmd = CreatePackage<SleepingbagAssigntoplayerCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
