using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Lists all paste files stored in the legacy server-side copypaste directory and prints their names to the console</summary>
/// <remarks>Full RCON name: <c>copypaste.list_pastes_sv</c></remarks>
public sealed class CopypasteListPastesSvCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "copypaste.list_pastes_sv";

    /// <summary>Creates a new <see cref="CopypasteListPastesSvCommand"/> command.</summary>
    public static CopypasteListPastesSvCommand Create()
    {
        var cmd = CreatePackage<CopypasteListPastesSvCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
