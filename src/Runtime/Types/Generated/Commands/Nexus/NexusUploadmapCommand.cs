using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Reupload the map image to the nexus. Normally happens automatically at server boot. WARNING: This will lag the server!</summary>
/// <remarks>Full RCON name: <c>nexus.uploadmap</c></remarks>
public sealed class NexusUploadmapCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.uploadmap";

    /// <summary>Creates a new <see cref="NexusUploadmapCommand"/> command.</summary>
    public static NexusUploadmapCommand Create()
    {
        var cmd = CreatePackage<NexusUploadmapCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
