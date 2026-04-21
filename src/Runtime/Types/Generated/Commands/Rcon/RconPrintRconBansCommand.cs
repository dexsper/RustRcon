using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Print a table of permanently banned IPs and networks. Use '--json' to return a JSON object</summary>
/// <remarks>Full RCON name: <c>rcon.print_rcon_bans</c></remarks>
public sealed class RconPrintRconBansCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.print_rcon_bans";

    /// <summary>Creates a new <see cref="RconPrintRconBansCommand"/> command.</summary>
    public static RconPrintRconBansCommand Create()
    {
        var cmd = CreatePackage<RconPrintRconBansCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
