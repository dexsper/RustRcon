using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a table of all asset pool entries showing asset type, current pooled count, and pool capacity</summary>
/// <remarks>Full RCON name: <c>pool.print_assets</c></remarks>
public sealed class PoolPrintAssetsCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "pool.print_assets";

    /// <summary>Creates a new <see cref="PoolPrintAssetsCommand"/> command.</summary>
    public static PoolPrintAssetsCommand Create(string args, bool json = false)
    {
        var cmd = CreatePackage<PoolPrintAssetsCommand>();
        var content = new System.Text.StringBuilder(CommandFullName);
        content.Append($" {args}");
        if (json) content.Append(" --json");
        cmd.Content = content.ToString();
        return cmd;
    }
}
