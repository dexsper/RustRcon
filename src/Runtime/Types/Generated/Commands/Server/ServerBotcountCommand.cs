using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Returns the current number of bot (AI-controlled player) entities active on the server</summary>
/// <remarks>Full RCON name: <c>server.botcount</c></remarks>
public sealed class ServerBotcountCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.botcount";

    /// <summary>Creates a new <see cref="ServerBotcountCommand"/> command.</summary>
    public static ServerBotcountCommand Create()
    {
        var cmd = CreatePackage<ServerBotcountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
