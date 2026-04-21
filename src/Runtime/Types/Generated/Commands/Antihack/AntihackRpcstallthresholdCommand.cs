using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.rpcstallthreshold</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.rpcstallthreshold</c></remarks>
public sealed class AntihackRpcstallthresholdCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.rpcstallthreshold";

    /// <summary>Reads the current value of <c>antihack.rpcstallthreshold</c>.</summary>
    public static AntihackRpcstallthresholdCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackRpcstallthresholdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.rpcstallthreshold</c> to <paramref name="value"/>.</summary>
    public static AntihackRpcstallthresholdCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackRpcstallthresholdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
