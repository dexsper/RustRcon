using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Will the in-game compass show at the top of the screen</summary>
/// <remarks>Full RCON name: <c>server.compassenabled</c></remarks>
public sealed class ServerCompassenabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.compassenabled";

    /// <summary>Reads the current value of <c>server.compassenabled</c>.</summary>
    public static ServerCompassenabledCommand CreateGet()
    {
        var cmd = CreatePackage<ServerCompassenabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.compassenabled</c> to <paramref name="value"/>.</summary>
    public static ServerCompassenabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerCompassenabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
