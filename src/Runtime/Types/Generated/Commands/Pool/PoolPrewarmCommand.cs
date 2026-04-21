using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, object pools are pre-allocated at startup to avoid first-use latency; increases startup time but reduces runtime GC stutter</summary>
/// <remarks>Full RCON name: <c>pool.prewarm</c></remarks>
public sealed class PoolPrewarmCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "pool.prewarm";

    /// <summary>Reads the current value of <c>pool.prewarm</c>.</summary>
    public static PoolPrewarmCommand CreateGet()
    {
        var cmd = CreatePackage<PoolPrewarmCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>pool.prewarm</c> to <paramref name="value"/>.</summary>
    public static PoolPrewarmCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PoolPrewarmCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
