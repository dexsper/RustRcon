using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Can players be wounded after receiving fatal damage</summary>
/// <remarks>Full RCON name: <c>server.woundingenabled</c></remarks>
public sealed class ServerWoundingenabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.woundingenabled";

    /// <summary>Reads the current value of <c>server.woundingenabled</c>.</summary>
    public static ServerWoundingenabledCommand CreateGet()
    {
        var cmd = CreatePackage<ServerWoundingenabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.woundingenabled</c> to <paramref name="value"/>.</summary>
    public static ServerWoundingenabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerWoundingenabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
