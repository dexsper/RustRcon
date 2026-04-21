using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum byte size of the network entity cache; 0 means no hard limit</summary>
/// <remarks>Full RCON name: <c>server.netcachesize</c></remarks>
public sealed class ServerNetcachesizeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.netcachesize";

    /// <summary>Reads the current value of <c>server.netcachesize</c>.</summary>
    public static ServerNetcachesizeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerNetcachesizeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.netcachesize</c> to <paramref name="value"/>.</summary>
    public static ServerNetcachesizeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerNetcachesizeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
