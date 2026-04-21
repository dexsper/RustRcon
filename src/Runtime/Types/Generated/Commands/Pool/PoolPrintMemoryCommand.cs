using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a table of all object pool entries showing type, capacity, active count, peak usage, hit/miss counts, and spill counts; supports --json</summary>
/// <remarks>Full RCON name: <c>pool.print_memory</c></remarks>
public sealed class PoolPrintMemoryCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "pool.print_memory";

    /// <summary>Creates a new <see cref="PoolPrintMemoryCommand"/> command.</summary>
    public static PoolPrintMemoryCommand Create(string args)
    {
        var cmd = CreatePackage<PoolPrintMemoryCommand>();
        cmd.Content = $"{CommandFullName} {args}";
        return cmd;
    }
}
