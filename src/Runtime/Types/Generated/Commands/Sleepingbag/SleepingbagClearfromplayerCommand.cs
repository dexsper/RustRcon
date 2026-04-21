using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Clears ownership of a sleeping bag (by entity ID), setting the owner ID to 0 and removing it from the old owner's bag list</summary>
/// <remarks>Full RCON name: <c>sleepingbag.clearfromplayer</c></remarks>
public sealed class SleepingbagClearfromplayerCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "sleepingbag.clearfromplayer";

    /// <summary>Creates a new <see cref="SleepingbagClearfromplayerCommand"/> command.</summary>
    public static SleepingbagClearfromplayerCommand Create()
    {
        var cmd = CreatePackage<SleepingbagClearfromplayerCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
