using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.rpcstallmode</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.rpcstallmode</c></remarks>
public sealed class AntihackRpcstallmodeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.rpcstallmode";

    /// <summary>Reads the current value of <c>antihack.rpcstallmode</c>.</summary>
    public static AntihackRpcstallmodeCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackRpcstallmodeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.rpcstallmode</c> to <paramref name="value"/>.</summary>
    public static AntihackRpcstallmodeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackRpcstallmodeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
