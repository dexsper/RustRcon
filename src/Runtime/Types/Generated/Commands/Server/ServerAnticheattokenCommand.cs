using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When true clients must provide a valid EAC token to connect; disable only for testing or modded environments</summary>
/// <remarks>Full RCON name: <c>server.anticheattoken</c></remarks>
public sealed class ServerAnticheattokenCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.anticheattoken";

    /// <summary>Reads the current value of <c>server.anticheattoken</c>.</summary>
    public static ServerAnticheattokenCommand CreateGet()
    {
        var cmd = CreatePackage<ServerAnticheattokenCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.anticheattoken</c> to <paramref name="value"/>.</summary>
    public static ServerAnticheattokenCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerAnticheattokenCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
