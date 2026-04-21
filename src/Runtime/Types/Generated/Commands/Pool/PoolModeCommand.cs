using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, object pools are pre-allocated at startup to avoid first-use latency; increases startup time but reduces runtime GC stutter</summary>
/// <remarks>Full RCON name: <c>pool.mode</c></remarks>
public sealed class PoolModeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "pool.mode";

    /// <summary>Reads the current value of <c>pool.mode</c>.</summary>
    public static PoolModeCommand CreateGet()
    {
        var cmd = CreatePackage<PoolModeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>pool.mode</c> to <paramref name="value"/>.</summary>
    public static PoolModeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<PoolModeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
