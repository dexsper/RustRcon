using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>analytics.uploaderstats</c>.</summary>
/// <remarks>Full RCON name: <c>analytics.uploaderstats</c></remarks>
public sealed class AnalyticsUploaderstatsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "analytics.uploaderstats";

    /// <summary>Creates a new <see cref="AnalyticsUploaderstatsCommand"/> command.</summary>
    public static AnalyticsUploaderstatsCommand Create()
    {
        var cmd = CreatePackage<AnalyticsUploaderstatsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
