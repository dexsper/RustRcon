using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Censors the Steam player list to make player tracking more difficult</summary>
/// <remarks>Full RCON name: <c>server.censorplayerlist</c></remarks>
public sealed class ServerCensorplayerlistCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.censorplayerlist";

    /// <summary>Reads the current value of <c>server.censorplayerlist</c>.</summary>
    public static ServerCensorplayerlistCommand CreateGet()
    {
        var cmd = CreatePackage<ServerCensorplayerlistCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.censorplayerlist</c> to <paramref name="value"/>.</summary>
    public static ServerCensorplayerlistCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerCensorplayerlistCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
