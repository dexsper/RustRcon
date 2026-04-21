using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a sorted table of network packet types and their cumulative call counts since logging was enabled; requires packetlog_enabled = true</summary>
/// <remarks>Full RCON name: <c>server.packetlog</c></remarks>
public sealed class ServerPacketlogCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.packetlog";

    /// <summary>Creates a new <see cref="ServerPacketlogCommand"/> command.</summary>
    public static ServerPacketlogCommand Create(bool json = false)
    {
        var cmd = CreatePackage<ServerPacketlogCommand>();
        var content = new System.Text.StringBuilder(CommandFullName);
        if (json) content.Append(" --json");
        cmd.Content = content.ToString();
        return cmd;
    }
}
