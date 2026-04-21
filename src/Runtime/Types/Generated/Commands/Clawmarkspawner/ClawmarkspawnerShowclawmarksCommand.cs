using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>clawmarkspawner.showclawmarks</c>.</summary>
/// <remarks>Full RCON name: <c>clawmarkspawner.showclawmarks</c></remarks>
public sealed class ClawmarkspawnerShowclawmarksCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "clawmarkspawner.showclawmarks";

    /// <summary>Creates a new <see cref="ClawmarkspawnerShowclawmarksCommand"/> command.</summary>
    public static ClawmarkspawnerShowclawmarksCommand Create()
    {
        var cmd = CreatePackage<ClawmarkspawnerShowclawmarksCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
