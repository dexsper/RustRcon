using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Can players use the in-game map</summary>
/// <remarks>Full RCON name: <c>server.mapenabled</c></remarks>
public sealed class ServerMapenabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.mapenabled";

    /// <summary>Reads the current value of <c>server.mapenabled</c>.</summary>
    public static ServerMapenabledCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMapenabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.mapenabled</c> to <paramref name="value"/>.</summary>
    public static ServerMapenabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerMapenabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
