using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints statistics about all player boats on the server including block counts, deployable counts, and resource totals</summary>
/// <remarks>Full RCON name: <c>playerboat.print_stats</c></remarks>
public sealed class PlayerboatPrintStatsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.print_stats";

    /// <summary>Creates a new <see cref="PlayerboatPrintStatsCommand"/> command.</summary>
    public static PlayerboatPrintStatsCommand Create()
    {
        var cmd = CreatePackage<PlayerboatPrintStatsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
