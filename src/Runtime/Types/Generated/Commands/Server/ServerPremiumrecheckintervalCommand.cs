using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How often to do premium status rechecks</summary>
/// <remarks>Full RCON name: <c>server.premiumrecheckinterval</c></remarks>
public sealed class ServerPremiumrecheckintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.premiumrecheckinterval";

    /// <summary>Reads the current value of <c>server.premiumrecheckinterval</c>.</summary>
    public static ServerPremiumrecheckintervalCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPremiumrecheckintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.premiumrecheckinterval</c> to <paramref name="value"/>.</summary>
    public static ServerPremiumrecheckintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerPremiumrecheckintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
