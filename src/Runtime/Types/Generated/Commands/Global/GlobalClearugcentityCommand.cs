using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Clears all UGC content from a single entity by network ID; reports success or failure</summary>
/// <remarks>Full RCON name: <c>global.clearugcentity</c></remarks>
public sealed class GlobalClearugcentityCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.clearugcentity";

    /// <summary>Creates a new <see cref="GlobalClearugcentityCommand"/> command.</summary>
    public static GlobalClearugcentityCommand Create()
    {
        var cmd = CreatePackage<GlobalClearugcentityCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
