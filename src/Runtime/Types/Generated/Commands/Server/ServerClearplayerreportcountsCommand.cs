using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Clear the player reports list</summary>
/// <remarks>Full RCON name: <c>server.clearplayerreportcounts</c></remarks>
public sealed class ServerClearplayerreportcountsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.clearplayerreportcounts";

    /// <summary>Creates a new <see cref="ServerClearplayerreportcountsCommand"/> command.</summary>
    public static ServerClearplayerreportcountsCommand Create()
    {
        var cmd = CreatePackage<ServerClearplayerreportcountsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
