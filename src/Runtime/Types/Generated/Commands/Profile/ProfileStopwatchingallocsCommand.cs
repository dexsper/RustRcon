using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Stops tracking of allocations</summary>
/// <remarks>Full RCON name: <c>profile.stopwatchingallocs</c></remarks>
public sealed class ProfileStopwatchingallocsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.stopwatchingallocs";

    /// <summary>Creates a new <see cref="ProfileStopwatchingallocsCommand"/> command.</summary>
    public static ProfileStopwatchingallocsCommand Create()
    {
        var cmd = CreatePackage<ProfileStopwatchingallocsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
