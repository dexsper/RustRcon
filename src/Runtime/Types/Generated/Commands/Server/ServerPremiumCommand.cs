using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Require a premium status account to connect to this server</summary>
/// <remarks>Full RCON name: <c>server.premium</c></remarks>
public sealed class ServerPremiumCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.premium";

    /// <summary>Reads the current value of <c>server.premium</c>.</summary>
    public static ServerPremiumCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPremiumCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.premium</c> to <paramref name="value"/>.</summary>
    public static ServerPremiumCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerPremiumCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
