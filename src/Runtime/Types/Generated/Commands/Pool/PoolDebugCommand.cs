using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, logs additional diagnostic information about pool hits, misses, and spills to the console</summary>
/// <remarks>Full RCON name: <c>pool.debug</c></remarks>
public sealed class PoolDebugCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "pool.debug";

    /// <summary>Reads the current value of <c>pool.debug</c>.</summary>
    public static PoolDebugCommand CreateGet()
    {
        var cmd = CreatePackage<PoolDebugCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>pool.debug</c> to <paramref name="value"/>.</summary>
    public static PoolDebugCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PoolDebugCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
