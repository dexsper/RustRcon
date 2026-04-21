using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints pool statistics for the camera renderer manager including active renderer count, pooled task count, and task creation/return counters</summary>
/// <remarks>Full RCON name: <c>camerarenderermanager.pool_stats</c></remarks>
public sealed class CamerarenderermanagerPoolStatsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "camerarenderermanager.pool_stats";

    /// <summary>Creates a new <see cref="CamerarenderermanagerPoolStatsCommand"/> command.</summary>
    public static CamerarenderermanagerPoolStatsCommand Create()
    {
        var cmd = CreatePackage<CamerarenderermanagerPoolStatsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
