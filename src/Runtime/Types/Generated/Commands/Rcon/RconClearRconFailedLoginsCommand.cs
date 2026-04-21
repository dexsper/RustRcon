using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Clear all failed login attempts</summary>
/// <remarks>Full RCON name: <c>rcon.clear_rcon_failed_logins</c></remarks>
public sealed class RconClearRconFailedLoginsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.clear_rcon_failed_logins";

    /// <summary>Creates a new <see cref="RconClearRconFailedLoginsCommand"/> command.</summary>
    public static RconClearRconFailedLoginsCommand Create()
    {
        var cmd = CreatePackage<RconClearRconFailedLoginsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
