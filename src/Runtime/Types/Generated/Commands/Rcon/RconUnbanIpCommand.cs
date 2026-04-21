using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Unban an IP address from connecting to RCON, will also remove all attempt history</summary>
/// <remarks>Full RCON name: <c>rcon.unban_ip</c></remarks>
public sealed class RconUnbanIpCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.unban_ip";

    /// <summary>Creates a new <see cref="RconUnbanIpCommand"/> command.</summary>
    public static RconUnbanIpCommand Create()
    {
        var cmd = CreatePackage<RconUnbanIpCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
