using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Server-side handler that collects all ServerAdmin+ShowInAdminUI convars and sends them to the admin client for editing via the admin UI</summary>
/// <remarks>Full RCON name: <c>global.adminui_requestserverconvars</c></remarks>
public sealed class GlobalAdminuiRequestserverconvarsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.adminui_requestserverconvars";

    /// <summary>Creates a new <see cref="GlobalAdminuiRequestserverconvarsCommand"/> command.</summary>
    public static GlobalAdminuiRequestserverconvarsCommand Create()
    {
        var cmd = CreatePackage<GlobalAdminuiRequestserverconvarsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
