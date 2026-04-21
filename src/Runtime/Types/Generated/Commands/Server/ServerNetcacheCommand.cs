using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Enables server-side network caching of entity state; when enabled only deltas are sent per update rather than the full entity data, significantly reducing bandwidth</summary>
/// <remarks>Full RCON name: <c>server.netcache</c></remarks>
public sealed class ServerNetcacheCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.netcache";

    /// <summary>Reads the current value of <c>server.netcache</c>.</summary>
    public static ServerNetcacheCommand CreateGet()
    {
        var cmd = CreatePackage<ServerNetcacheCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.netcache</c> to <paramref name="value"/>.</summary>
    public static ServerNetcacheCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerNetcacheCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
