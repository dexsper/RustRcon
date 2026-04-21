using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.tick_buffer_preventions</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.tick_buffer_preventions</c></remarks>
public sealed class AntihackTickBufferPreventionsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.tick_buffer_preventions";

    /// <summary>Reads the current value of <c>antihack.tick_buffer_preventions</c>.</summary>
    public static AntihackTickBufferPreventionsCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackTickBufferPreventionsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.tick_buffer_preventions</c> to <paramref name="value"/>.</summary>
    public static AntihackTickBufferPreventionsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackTickBufferPreventionsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
