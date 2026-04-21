using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Easy Anti-Cheat product key used alongside anticheatid for EAC server authentication</summary>
/// <remarks>Full RCON name: <c>server.anticheatkey</c></remarks>
public sealed class ServerAnticheatkeyCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.anticheatkey";

    /// <summary>Reads the current value of <c>server.anticheatkey</c>.</summary>
    public static ServerAnticheatkeyCommand CreateGet()
    {
        var cmd = CreatePackage<ServerAnticheatkeyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.anticheatkey</c> to <paramref name="value"/>.</summary>
    public static ServerAnticheatkeyCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerAnticheatkeyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
