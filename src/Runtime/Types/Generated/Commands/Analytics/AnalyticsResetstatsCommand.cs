using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>analytics.resetstats</c>.</summary>
/// <remarks>Full RCON name: <c>analytics.resetstats</c></remarks>
public sealed class AnalyticsResetstatsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.resetstats";

    /// <summary>Creates a new <see cref="AnalyticsResetstatsCommand"/> command.</summary>
    public static AnalyticsResetstatsCommand Create()
    {
        var cmd = CreatePackage<AnalyticsResetstatsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
