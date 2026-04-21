using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Sets the minimum delay in seconds between automatic triggers of the named server event</summary>
/// <remarks>Full RCON name: <c>events.set_event_min_delay</c></remarks>
public sealed class EventsSetEventMinDelayCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "events.set_event_min_delay";

    /// <summary>Creates a new <see cref="EventsSetEventMinDelayCommand"/> command.</summary>
    public static EventsSetEventMinDelayCommand Create(string arg0, float arg1)
    {
        var cmd = CreatePackage<EventsSetEventMinDelayCommand>();
        cmd.Content = $"{CommandFullName} {arg0} {arg1}";
        return cmd;
    }
}
