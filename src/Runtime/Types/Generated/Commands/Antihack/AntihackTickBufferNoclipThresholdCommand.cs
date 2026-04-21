using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.tick_buffer_noclip_threshold</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.tick_buffer_noclip_threshold</c></remarks>
public sealed class AntihackTickBufferNoclipThresholdCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.tick_buffer_noclip_threshold";

    /// <summary>Reads the current value of <c>antihack.tick_buffer_noclip_threshold</c>.</summary>
    public static AntihackTickBufferNoclipThresholdCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackTickBufferNoclipThresholdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.tick_buffer_noclip_threshold</c> to <paramref name="value"/>.</summary>
    public static AntihackTickBufferNoclipThresholdCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackTickBufferNoclipThresholdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
