using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>boatbuildingstation.print_stats</c>.</summary>
/// <remarks>Full RCON name: <c>boatbuildingstation.print_stats</c></remarks>
public sealed class BoatbuildingstationPrintStatsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatbuildingstation.print_stats";

    /// <summary>Creates a new <see cref="BoatbuildingstationPrintStatsCommand"/> command.</summary>
    public static BoatbuildingstationPrintStatsCommand Create()
    {
        var cmd = CreatePackage<BoatbuildingstationPrintStatsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
