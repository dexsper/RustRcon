using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Clears all UGC content (images, patterns) from the entity with the given network ID and notifies the IUGCBrowserEntity component</summary>
/// <remarks>Full RCON name: <c>global.adminui_deleteugccontent</c></remarks>
public sealed class GlobalAdminuiDeleteugccontentCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.adminui_deleteugccontent";

    /// <summary>Creates a new <see cref="GlobalAdminuiDeleteugccontentCommand"/> command.</summary>
    public static GlobalAdminuiDeleteugccontentCommand Create()
    {
        var cmd = CreatePackage<GlobalAdminuiDeleteugccontentCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
