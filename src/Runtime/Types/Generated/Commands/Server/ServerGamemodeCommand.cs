using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Short name of the game mode to activate on this server (e.g. 'softcore', 'hardcore'); applies convar overrides defined by that game mode's prefab</summary>
/// <remarks>Full RCON name: <c>server.gamemode</c></remarks>
public sealed class ServerGamemodeCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.gamemode";

    /// <summary>Reads the current value of <c>server.gamemode</c>.</summary>
    public static ServerGamemodeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerGamemodeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.gamemode</c> to <paramref name="value"/>.</summary>
    public static ServerGamemodeCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerGamemodeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
