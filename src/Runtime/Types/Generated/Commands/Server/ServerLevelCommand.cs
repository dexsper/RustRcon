using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Map level to load on startup, e.g. 'Procedural Map', 'Barren', or a custom map name</summary>
/// <remarks>Full RCON name: <c>server.level</c></remarks>
public sealed class ServerLevelCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.level";

    /// <summary>Reads the current value of <c>server.level</c>.</summary>
    public static ServerLevelCommand CreateGet()
    {
        var cmd = CreatePackage<ServerLevelCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.level</c> to <paramref name="value"/>.</summary>
    public static ServerLevelCommand CreateSet(string value)
    {
        var cmd = CreatePackage<ServerLevelCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
