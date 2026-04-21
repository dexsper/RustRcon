using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Minimum time to recheck premium status for already connected players (in seconds)</summary>
/// <remarks>Full RCON name: <c>server.premiumrecheckminseconds</c></remarks>
public sealed class ServerPremiumrecheckminsecondsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.premiumrecheckminseconds";

    /// <summary>Reads the current value of <c>server.premiumrecheckminseconds</c>.</summary>
    public static ServerPremiumrecheckminsecondsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPremiumrecheckminsecondsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.premiumrecheckminseconds</c> to <paramref name="value"/>.</summary>
    public static ServerPremiumrecheckminsecondsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerPremiumrecheckminsecondsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
