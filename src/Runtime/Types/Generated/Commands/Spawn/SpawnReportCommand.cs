using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a spawn handler report listing all populations, their current count, target count, and fill percentage; pass true for detailed mode or a name filter as a second argument</summary>
/// <remarks>Full RCON name: <c>spawn.report</c></remarks>
public sealed class SpawnReportCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.report";

    /// <summary>Creates a new <see cref="SpawnReportCommand"/> command.</summary>
    public static SpawnReportCommand Create()
    {
        var cmd = CreatePackage<SpawnReportCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
