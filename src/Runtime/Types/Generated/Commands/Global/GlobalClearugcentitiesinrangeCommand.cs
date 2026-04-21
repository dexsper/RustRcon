using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Clears UGC content from all entities within the given radius of a world position; reports how many entities were cleared</summary>
/// <remarks>Full RCON name: <c>global.clearugcentitiesinrange</c></remarks>
public sealed class GlobalClearugcentitiesinrangeCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.clearugcentitiesinrange";

    /// <summary>Creates a new <see cref="GlobalClearugcentitiesinrangeCommand"/> command.</summary>
    public static GlobalClearugcentitiesinrangeCommand Create(float value)
    {
        var cmd = CreatePackage<GlobalClearugcentitiesinrangeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
