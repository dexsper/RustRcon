using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Prints all the Tool Cupboards on the server</summary>
/// <remarks>Full RCON name: <c>server.listtoolcupboards</c></remarks>
public sealed class ServerListtoolcupboardsCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.listtoolcupboards";

    /// <summary>Creates a new <see cref="ServerListtoolcupboardsCommand"/> command.</summary>
    public static ServerListtoolcupboardsCommand Create(bool json = false)
    {
        var cmd = CreatePackage<ServerListtoolcupboardsCommand>();
        var content = new System.Text.StringBuilder(CommandFullName);
        if (json) content.Append(" --json");
        cmd.Content = content.ToString();
        return cmd;
    }
}
