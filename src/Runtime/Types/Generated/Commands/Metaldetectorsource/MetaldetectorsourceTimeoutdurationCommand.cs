using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>metaldetectorsource.timeoutduration</c>.</summary>
/// <remarks>Full RCON name: <c>metaldetectorsource.timeoutduration</c></remarks>
public sealed class MetaldetectorsourceTimeoutdurationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "metaldetectorsource.timeoutduration";

    /// <summary>Reads the current value of <c>metaldetectorsource.timeoutduration</c>.</summary>
    public static MetaldetectorsourceTimeoutdurationCommand CreateGet()
    {
        var cmd = CreatePackage<MetaldetectorsourceTimeoutdurationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>metaldetectorsource.timeoutduration</c> to <paramref name="value"/>.</summary>
    public static MetaldetectorsourceTimeoutdurationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<MetaldetectorsourceTimeoutdurationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
