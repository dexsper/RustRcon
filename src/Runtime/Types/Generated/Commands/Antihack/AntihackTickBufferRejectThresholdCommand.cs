using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.tick_buffer_reject_threshold</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.tick_buffer_reject_threshold</c></remarks>
public sealed class AntihackTickBufferRejectThresholdCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.tick_buffer_reject_threshold";

    /// <summary>Reads the current value of <c>antihack.tick_buffer_reject_threshold</c>.</summary>
    public static AntihackTickBufferRejectThresholdCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackTickBufferRejectThresholdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.tick_buffer_reject_threshold</c> to <paramref name="value"/>.</summary>
    public static AntihackTickBufferRejectThresholdCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackTickBufferRejectThresholdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
