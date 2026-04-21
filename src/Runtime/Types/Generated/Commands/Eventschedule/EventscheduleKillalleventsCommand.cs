using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Kills all currently running triggered event instances across all enabled event schedules; registered as eventschedule.killallevents</summary>
/// <remarks>Full RCON name: <c>eventschedule.killallevents</c></remarks>
public sealed class EventscheduleKillalleventsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "eventschedule.killallevents";

    /// <summary>Creates a new <see cref="EventscheduleKillalleventsCommand"/> command.</summary>
    public static EventscheduleKillalleventsCommand Create()
    {
        var cmd = CreatePackage<EventscheduleKillalleventsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
