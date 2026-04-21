using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Resets the peak-usage high-water-mark counter for all pools, allowing fresh measurement of maximum pool demand</summary>
/// <remarks>Full RCON name: <c>pool.reset_max_pool_counter</c></remarks>
public sealed class PoolResetMaxPoolCounterCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "pool.reset_max_pool_counter";

    /// <summary>Creates a new <see cref="PoolResetMaxPoolCounterCommand"/> command.</summary>
    public static PoolResetMaxPoolCounterCommand Create()
    {
        var cmd = CreatePackage<PoolResetMaxPoolCounterCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
