using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Server-side handler that serialises and sends the current player list to the requesting admin client for display in the admin UI</summary>
/// <remarks>Full RCON name: <c>global.adminui_requestplayerlist</c></remarks>
public sealed class GlobalAdminuiRequestplayerlistCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.adminui_requestplayerlist";

    /// <summary>Creates a new <see cref="GlobalAdminuiRequestplayerlistCommand"/> command.</summary>
    public static GlobalAdminuiRequestplayerlistCommand Create()
    {
        var cmd = CreatePackage<GlobalAdminuiRequestplayerlistCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
