using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>ziplinelaunchpoint.report</c>.</summary>
/// <remarks>Full RCON name: <c>ziplinelaunchpoint.report</c></remarks>
public sealed class ZiplinelaunchpointReportCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ziplinelaunchpoint.report";

    /// <summary>Creates a new <see cref="ZiplinelaunchpointReportCommand"/> command.</summary>
    public static ZiplinelaunchpointReportCommand Create()
    {
        var cmd = CreatePackage<ZiplinelaunchpointReportCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
