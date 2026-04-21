using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, this system is globally active; disable to deactivate the system for the current session</summary>
/// <remarks>Full RCON name: <c>gc.enabled</c></remarks>
public sealed class GcEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "gc.enabled";

    /// <summary>Reads the current value of <c>gc.enabled</c>.</summary>
    public static GcEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<GcEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>gc.enabled</c> to <paramref name="value"/>.</summary>
    public static GcEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<GcEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
