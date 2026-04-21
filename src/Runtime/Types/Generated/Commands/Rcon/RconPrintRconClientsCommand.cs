using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Print a table of connected RCON clients. Use '--json' to return a JSON object</summary>
/// <remarks>Full RCON name: <c>rcon.print_rcon_clients</c></remarks>
public sealed class RconPrintRconClientsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.print_rcon_clients";

    /// <summary>Creates a new <see cref="RconPrintRconClientsCommand"/> command.</summary>
    public static RconPrintRconClientsCommand Create()
    {
        var cmd = CreatePackage<RconPrintRconClientsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
