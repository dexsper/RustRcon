using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Triggers a named event schedule by partial name match; registered as eventschedule.triggerevent; lists available events if name is invalid or ambiguous</summary>
/// <remarks>Full RCON name: <c>eventschedule.triggerevent</c></remarks>
public sealed class EventscheduleTriggereventCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "eventschedule.triggerevent";

    /// <summary>Creates a new <see cref="EventscheduleTriggereventCommand"/> command.</summary>
    public static EventscheduleTriggereventCommand Create()
    {
        var cmd = CreatePackage<EventscheduleTriggereventCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
