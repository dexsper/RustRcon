using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum byte size of a single global-entities network packet; oversized packets are dropped</summary>
/// <remarks>Full RCON name: <c>server.maxpacketsize_globalentities</c></remarks>
public sealed class ServerMaxpacketsizeGlobalentitiesCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxpacketsize_globalentities";

    /// <summary>Reads the current value of <c>server.maxpacketsize_globalentities</c>.</summary>
    public static ServerMaxpacketsizeGlobalentitiesCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxpacketsizeGlobalentitiesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxpacketsize_globalentities</c> to <paramref name="value"/>.</summary>
    public static ServerMaxpacketsizeGlobalentitiesCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxpacketsizeGlobalentitiesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
