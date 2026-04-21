using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When true players are kicked if Steam authentication fails; disable to allow connections when Steam auth servers are unreachable</summary>
/// <remarks>Full RCON name: <c>server.strictauth_steam</c></remarks>
public sealed class ServerStrictauthSteamCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.strictauth_steam";

    /// <summary>Reads the current value of <c>server.strictauth_steam</c>.</summary>
    public static ServerStrictauthSteamCommand CreateGet()
    {
        var cmd = CreatePackage<ServerStrictauthSteamCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.strictauth_steam</c> to <paramref name="value"/>.</summary>
    public static ServerStrictauthSteamCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerStrictauthSteamCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
