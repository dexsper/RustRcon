using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, this system is globally active; disable to deactivate the system for the current session</summary>
/// <remarks>Full RCON name: <c>pool.enabled</c></remarks>
public sealed class PoolEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "pool.enabled";

    /// <summary>Reads the current value of <c>pool.enabled</c>.</summary>
    public static PoolEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<PoolEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>pool.enabled</c> to <paramref name="value"/>.</summary>
    public static PoolEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PoolEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
