using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Print a table of clients with failed passwords.  Use '--json' to return a JSON object</summary>
/// <remarks>Full RCON name: <c>rcon.print_rcon_failed_logins</c></remarks>
public sealed class RconPrintRconFailedLoginsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.print_rcon_failed_logins";

    /// <summary>Creates a new <see cref="RconPrintRconFailedLoginsCommand"/> command.</summary>
    public static RconPrintRconFailedLoginsCommand Create()
    {
        var cmd = CreatePackage<RconPrintRconFailedLoginsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
