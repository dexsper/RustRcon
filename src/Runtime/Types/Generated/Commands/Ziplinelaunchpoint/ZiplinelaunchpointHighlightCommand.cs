using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>ziplinelaunchpoint.highlight</c>.</summary>
/// <remarks>Full RCON name: <c>ziplinelaunchpoint.highlight</c></remarks>
public sealed class ZiplinelaunchpointHighlightCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ziplinelaunchpoint.highlight";

    /// <summary>Creates a new <see cref="ZiplinelaunchpointHighlightCommand"/> command.</summary>
    public static ZiplinelaunchpointHighlightCommand Create()
    {
        var cmd = CreatePackage<ZiplinelaunchpointHighlightCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
