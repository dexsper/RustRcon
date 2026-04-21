using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(default) true = only broadcast to clients with global networking enabled, false = broadcast to every client regardless</summary>
/// <remarks>Full RCON name: <c>net.limit_global_update_broadcast</c></remarks>
public sealed class NetLimitGlobalUpdateBroadcastCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "net.limit_global_update_broadcast";

    /// <summary>Reads the current value of <c>net.limit_global_update_broadcast</c>.</summary>
    public static NetLimitGlobalUpdateBroadcastCommand CreateGet()
    {
        var cmd = CreatePackage<NetLimitGlobalUpdateBroadcastCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>net.limit_global_update_broadcast</c> to <paramref name="value"/>.</summary>
    public static NetLimitGlobalUpdateBroadcastCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<NetLimitGlobalUpdateBroadcastCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
