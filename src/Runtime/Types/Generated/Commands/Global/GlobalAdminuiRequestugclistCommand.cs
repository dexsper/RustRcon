using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Server-side handler that scans all entities for UGC content (images, patterns, vending names) and sends a serialised list to the admin client</summary>
/// <remarks>Full RCON name: <c>global.adminui_requestugclist</c></remarks>
public sealed class GlobalAdminuiRequestugclistCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.adminui_requestugclist";

    /// <summary>Creates a new <see cref="GlobalAdminuiRequestugclistCommand"/> command.</summary>
    public static GlobalAdminuiRequestugclistCommand Create()
    {
        var cmd = CreatePackage<GlobalAdminuiRequestugclistCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
