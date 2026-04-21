using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum byte size of a single global-trees network packet; oversized packets are dropped</summary>
/// <remarks>Full RCON name: <c>server.maxpacketsize_globaltrees</c></remarks>
public sealed class ServerMaxpacketsizeGlobaltreesCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxpacketsize_globaltrees";

    /// <summary>Reads the current value of <c>server.maxpacketsize_globaltrees</c>.</summary>
    public static ServerMaxpacketsizeGlobaltreesCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxpacketsizeGlobaltreesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxpacketsize_globaltrees</c> to <paramref name="value"/>.</summary>
    public static ServerMaxpacketsizeGlobaltreesCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxpacketsizeGlobaltreesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
