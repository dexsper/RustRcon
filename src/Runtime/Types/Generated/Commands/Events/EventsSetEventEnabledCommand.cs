using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Enables or disables a specific server event by name; disabled events will not trigger automatically until re-enabled</summary>
/// <remarks>Full RCON name: <c>events.set_event_enabled</c></remarks>
public sealed class EventsSetEventEnabledCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "events.set_event_enabled";

    /// <summary>Creates a new <see cref="EventsSetEventEnabledCommand"/> command.</summary>
    public static EventsSetEventEnabledCommand Create(string arg0, bool arg1)
    {
        var cmd = CreatePackage<EventsSetEventEnabledCommand>();
        cmd.Content = $"{CommandFullName} {arg0} {arg1}";
        return cmd;
    }
}
