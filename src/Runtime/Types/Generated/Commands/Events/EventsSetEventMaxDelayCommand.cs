using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Sets the maximum delay in seconds between automatic triggers of the named server event</summary>
/// <remarks>Full RCON name: <c>events.set_event_max_delay</c></remarks>
public sealed class EventsSetEventMaxDelayCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "events.set_event_max_delay";

    /// <summary>Creates a new <see cref="EventsSetEventMaxDelayCommand"/> command.</summary>
    public static EventsSetEventMaxDelayCommand Create(string arg0, float arg1)
    {
        var cmd = CreatePackage<EventsSetEventMaxDelayCommand>();
        cmd.Content = $"{CommandFullName} {arg0} {arg1}";
        return cmd;
    }
}
