using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many pings can be placed by each player</summary>
/// <remarks>Full RCON name: <c>server.maximumpings</c></remarks>
public sealed class ServerMaximumpingsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maximumpings";

    /// <summary>Reads the current value of <c>server.maximumpings</c>.</summary>
    public static ServerMaximumpingsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaximumpingsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maximumpings</c> to <paramref name="value"/>.</summary>
    public static ServerMaximumpingsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaximumpingsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
