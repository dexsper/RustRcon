using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Ban an IP address from RCON, preventing it from connecting and kick any clients from this IP, this is permanent and persistent</summary>
/// <remarks>Full RCON name: <c>rcon.ban_ip</c></remarks>
public sealed class RconBanIpCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.ban_ip";

    /// <summary>Creates a new <see cref="RconBanIpCommand"/> command.</summary>
    public static RconBanIpCommand Create()
    {
        var cmd = CreatePackage<RconBanIpCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
