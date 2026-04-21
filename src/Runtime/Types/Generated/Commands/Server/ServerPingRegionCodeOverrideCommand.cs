using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Override the geographic region code used for ping estimation in the server browser; leave empty to use automatic detection</summary>
/// <remarks>Full RCON name: <c>server.ping_region_code_override</c></remarks>
public sealed class ServerPingRegionCodeOverrideCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.ping_region_code_override";

    /// <summary>Reads the current value of <c>server.ping_region_code_override</c>.</summary>
    public static ServerPingRegionCodeOverrideCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPingRegionCodeOverrideCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.ping_region_code_override</c> to <paramref name="value"/>.</summary>
    public static ServerPingRegionCodeOverrideCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerPingRegionCodeOverrideCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
