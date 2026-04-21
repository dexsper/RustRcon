using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Server-side handler that destroys all entities within the current selection bounds that match the active paste filter options (NPCs, vehicles, deployables etc.)</summary>
/// <remarks>Full RCON name: <c>copypaste.killbox_sv</c></remarks>
public sealed class CopypasteKillboxSvCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "copypaste.killbox_sv";

    /// <summary>Creates a new <see cref="CopypasteKillboxSvCommand"/> command.</summary>
    public static CopypasteKillboxSvCommand Create()
    {
        var cmd = CreatePackage<CopypasteKillboxSvCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
