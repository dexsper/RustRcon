using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a table of all registered server events with their current enabled state, minimum delay, maximum delay, and last trigger time</summary>
/// <remarks>Full RCON name: <c>events.print_server_events</c></remarks>
public sealed class EventsPrintServerEventsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "events.print_server_events";

    /// <summary>Creates a new <see cref="EventsPrintServerEventsCommand"/> command.</summary>
    public static EventsPrintServerEventsCommand Create()
    {
        var cmd = CreatePackage<EventsPrintServerEventsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
