using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>metaldetectorflag.timeoutduration</c>.</summary>
/// <remarks>Full RCON name: <c>metaldetectorflag.timeoutduration</c></remarks>
public sealed class MetaldetectorflagTimeoutdurationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "metaldetectorflag.timeoutduration";

    /// <summary>Reads the current value of <c>metaldetectorflag.timeoutduration</c>.</summary>
    public static MetaldetectorflagTimeoutdurationCommand CreateGet()
    {
        var cmd = CreatePackage<MetaldetectorflagTimeoutdurationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>metaldetectorflag.timeoutduration</c> to <paramref name="value"/>.</summary>
    public static MetaldetectorflagTimeoutdurationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<MetaldetectorflagTimeoutdurationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
