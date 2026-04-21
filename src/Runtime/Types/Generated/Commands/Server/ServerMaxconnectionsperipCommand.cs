using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of simultaneous connections allowed from the same IP address; helps mitigate connection-flooding attacks (clamped 1–1000)</summary>
/// <remarks>Full RCON name: <c>server.maxconnectionsperip</c></remarks>
public sealed class ServerMaxconnectionsperipCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxconnectionsperip";

    /// <summary>Reads the current value of <c>server.maxconnectionsperip</c>.</summary>
    public static ServerMaxconnectionsperipCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxconnectionsperipCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxconnectionsperip</c> to <paramref name="value"/>.</summary>
    public static ServerMaxconnectionsperipCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxconnectionsperipCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
