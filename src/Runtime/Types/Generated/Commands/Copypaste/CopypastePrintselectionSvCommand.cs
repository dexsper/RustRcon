using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Server-side handler that prints the names of all entities within the current selection bounds; used to preview what would be included in a copy operation</summary>
/// <remarks>Full RCON name: <c>copypaste.printselection_sv</c></remarks>
public sealed class CopypastePrintselectionSvCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "copypaste.printselection_sv";

    /// <summary>Creates a new <see cref="CopypastePrintselectionSvCommand"/> command.</summary>
    public static CopypastePrintselectionSvCommand Create()
    {
        var cmd = CreatePackage<CopypastePrintselectionSvCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
