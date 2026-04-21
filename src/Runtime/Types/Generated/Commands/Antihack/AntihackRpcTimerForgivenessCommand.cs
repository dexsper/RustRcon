using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.rpc_timer_forgiveness</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.rpc_timer_forgiveness</c></remarks>
public sealed class AntihackRpcTimerForgivenessCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.rpc_timer_forgiveness";

    /// <summary>Reads the current value of <c>antihack.rpc_timer_forgiveness</c>.</summary>
    public static AntihackRpcTimerForgivenessCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackRpcTimerForgivenessCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.rpc_timer_forgiveness</c> to <paramref name="value"/>.</summary>
    public static AntihackRpcTimerForgivenessCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackRpcTimerForgivenessCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
