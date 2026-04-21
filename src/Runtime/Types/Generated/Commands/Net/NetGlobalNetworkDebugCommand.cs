using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Toggle printing time taken to send all global entities to client when they connect</summary>
/// <remarks>Full RCON name: <c>net.global_network_debug</c></remarks>
public sealed class NetGlobalNetworkDebugCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "net.global_network_debug";

    /// <summary>Reads the current value of <c>net.global_network_debug</c>.</summary>
    public static NetGlobalNetworkDebugCommand CreateGet()
    {
        var cmd = CreatePackage<NetGlobalNetworkDebugCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>net.global_network_debug</c> to <paramref name="value"/>.</summary>
    public static NetGlobalNetworkDebugCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<NetGlobalNetworkDebugCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
