using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Server-side handler that serialises and sends current server info (name, players, FPS, etc.) to the requesting admin client</summary>
/// <remarks>Full RCON name: <c>global.adminui_requestserverinfo</c></remarks>
public sealed class GlobalAdminuiRequestserverinfoCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.adminui_requestserverinfo";

    /// <summary>Creates a new <see cref="GlobalAdminuiRequestserverinfoCommand"/> command.</summary>
    public static GlobalAdminuiRequestserverinfoCommand Create()
    {
        var cmd = CreatePackage<GlobalAdminuiRequestserverinfoCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
