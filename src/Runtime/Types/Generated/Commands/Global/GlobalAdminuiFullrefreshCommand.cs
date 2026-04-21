using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Triggers a full refresh of the admin UI by requesting the player list, server info, convars, and UGC list all at once</summary>
/// <remarks>Full RCON name: <c>global.adminui_fullrefresh</c></remarks>
public sealed class GlobalAdminuiFullrefreshCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.adminui_fullrefresh";

    /// <summary>Creates a new <see cref="GlobalAdminuiFullrefreshCommand"/> command.</summary>
    public static GlobalAdminuiFullrefreshCommand Create()
    {
        var cmd = CreatePackage<GlobalAdminuiFullrefreshCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
