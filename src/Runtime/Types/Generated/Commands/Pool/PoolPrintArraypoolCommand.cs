using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a usage report for the BaseNetwork and ProtocolParser array pools, showing bucket sizes, capacities, and hit/miss stats</summary>
/// <remarks>Full RCON name: <c>pool.print_arraypool</c></remarks>
public sealed class PoolPrintArraypoolCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "pool.print_arraypool";

    /// <summary>Creates a new <see cref="PoolPrintArraypoolCommand"/> command.</summary>
    public static PoolPrintArraypoolCommand Create(bool json = false)
    {
        var cmd = CreatePackage<PoolPrintArraypoolCommand>();
        var content = new System.Text.StringBuilder(CommandFullName);
        if (json) content.Append(" --json");
        cmd.Content = content.ToString();
        return cmd;
    }
}
