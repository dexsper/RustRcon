using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Enables packet-type logging; must be true before the packetlog command will return data. Collects packet type call counts at runtime</summary>
/// <remarks>Full RCON name: <c>server.packetlog_enabled</c></remarks>
public sealed class ServerPacketlogEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.packetlog_enabled";

    /// <summary>Reads the current value of <c>server.packetlog_enabled</c>.</summary>
    public static ServerPacketlogEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPacketlogEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.packetlog_enabled</c> to <paramref name="value"/>.</summary>
    public static ServerPacketlogEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerPacketlogEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
