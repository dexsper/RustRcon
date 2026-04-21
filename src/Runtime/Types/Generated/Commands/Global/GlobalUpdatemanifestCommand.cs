using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Immediately update the manifest</summary>
/// <remarks>Full RCON name: <c>global.updatemanifest</c></remarks>
public sealed class GlobalUpdatemanifestCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.updatemanifest";

    /// <summary>Creates a new <see cref="GlobalUpdatemanifestCommand"/> command.</summary>
    public static GlobalUpdatemanifestCommand Create()
    {
        var cmd = CreatePackage<GlobalUpdatemanifestCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
