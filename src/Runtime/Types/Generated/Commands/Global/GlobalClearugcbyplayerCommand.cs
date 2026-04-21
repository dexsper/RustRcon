using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Clears UGC content from all entities that have the specified player (by name or Steam ID) in their editing history</summary>
/// <remarks>Full RCON name: <c>global.clearugcbyplayer</c></remarks>
public sealed class GlobalClearugcbyplayerCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.clearugcbyplayer";

    /// <summary>Creates a new <see cref="GlobalClearugcbyplayerCommand"/> command.</summary>
    public static GlobalClearugcbyplayerCommand Create(ulong value)
    {
        var cmd = CreatePackage<GlobalClearugcbyplayerCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
