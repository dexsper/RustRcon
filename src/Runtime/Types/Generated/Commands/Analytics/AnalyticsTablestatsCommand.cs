using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>analytics.tablestats</c>.</summary>
/// <remarks>Full RCON name: <c>analytics.tablestats</c></remarks>
public sealed class AnalyticsTablestatsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.tablestats";

    /// <summary>Creates a new <see cref="AnalyticsTablestatsCommand"/> command.</summary>
    public static AnalyticsTablestatsCommand Create()
    {
        var cmd = CreatePackage<AnalyticsTablestatsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
