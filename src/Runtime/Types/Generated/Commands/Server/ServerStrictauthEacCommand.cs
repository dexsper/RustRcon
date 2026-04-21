using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When true players are kicked if EAC authentication fails; disable to allow players through even when EAC is unavailable</summary>
/// <remarks>Full RCON name: <c>server.strictauth_eac</c></remarks>
public sealed class ServerStrictauthEacCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.strictauth_eac";

    /// <summary>Reads the current value of <c>server.strictauth_eac</c>.</summary>
    public static ServerStrictauthEacCommand CreateGet()
    {
        var cmd = CreatePackage<ServerStrictauthEacCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.strictauth_eac</c> to <paramref name="value"/>.</summary>
    public static ServerStrictauthEacCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerStrictauthEacCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
