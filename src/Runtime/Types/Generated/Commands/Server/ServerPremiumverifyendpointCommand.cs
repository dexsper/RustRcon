using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Endpoint to use to check if players have premium status</summary>
/// <remarks>Full RCON name: <c>server.premiumverifyendpoint</c></remarks>
public sealed class ServerPremiumverifyendpointCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.premiumverifyendpoint";

    /// <summary>Reads the current value of <c>server.premiumverifyendpoint</c>.</summary>
    public static ServerPremiumverifyendpointCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPremiumverifyendpointCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.premiumverifyendpoint</c> to <paramref name="value"/>.</summary>
    public static ServerPremiumverifyendpointCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerPremiumverifyendpointCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
