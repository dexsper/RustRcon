using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) UDP port used for Steam server browser queries; uses the game port if set to 0</summary>
/// <remarks>Full RCON name: <c>server.queryport</c></remarks>
public sealed class ServerQueryportCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.queryport";

    /// <summary>Reads the current value of <c>server.queryport</c>.</summary>
    public static ServerQueryportCommand CreateGet()
    {
        var cmd = CreatePackage<ServerQueryportCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.queryport</c> to <paramref name="value"/>.</summary>
    public static ServerQueryportCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerQueryportCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
