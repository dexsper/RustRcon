using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>List the amount of reports players on the server have received</summary>
/// <remarks>Full RCON name: <c>server.listplayerreportcounts</c></remarks>
public sealed class ServerListplayerreportcountsCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.listplayerreportcounts";

    /// <summary>Creates a new <see cref="ServerListplayerreportcountsCommand"/> command.</summary>
    public static ServerListplayerreportcountsCommand Create(bool json = false)
    {
        var cmd = CreatePackage<ServerListplayerreportcountsCommand>();
        var content = new System.Text.StringBuilder(CommandFullName);
        if (json) content.Append(" --json");
        cmd.Content = content.ToString();
        return cmd;
    }
}
