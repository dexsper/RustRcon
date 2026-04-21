using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, logs debug information about AI ejection events when passengers are removed from boat seats</summary>
/// <remarks>Full RCON name: <c>baseboat.debug_eject_ai</c></remarks>
public sealed class BaseboatDebugEjectAiCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "baseboat.debug_eject_ai";

    /// <summary>Reads the current value of <c>baseboat.debug_eject_ai</c>.</summary>
    public static BaseboatDebugEjectAiCommand CreateGet()
    {
        var cmd = CreatePackage<BaseboatDebugEjectAiCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>baseboat.debug_eject_ai</c> to <paramref name="value"/>.</summary>
    public static BaseboatDebugEjectAiCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BaseboatDebugEjectAiCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
