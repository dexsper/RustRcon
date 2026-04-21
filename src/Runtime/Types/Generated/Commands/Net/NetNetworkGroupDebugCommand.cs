using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Toggle checking network group bounds whenever an entity changes its network group</summary>
/// <remarks>Full RCON name: <c>net.network_group_debug</c></remarks>
public sealed class NetNetworkGroupDebugCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "net.network_group_debug";

    /// <summary>Reads the current value of <c>net.network_group_debug</c>.</summary>
    public static NetNetworkGroupDebugCommand CreateGet()
    {
        var cmd = CreatePackage<NetNetworkGroupDebugCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>net.network_group_debug</c> to <paramref name="value"/>.</summary>
    public static NetNetworkGroupDebugCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<NetNetworkGroupDebugCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
