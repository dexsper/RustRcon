using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a table of all prefab pool entries showing prefab name, miss count, current count, target capacity, and push/pop counts; supports --json</summary>
/// <remarks>Full RCON name: <c>pool.print_prefabs</c></remarks>
public sealed class PoolPrintPrefabsCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "pool.print_prefabs";

    /// <summary>Creates a new <see cref="PoolPrintPrefabsCommand"/> command.</summary>
    public static PoolPrintPrefabsCommand Create(string args, bool json = false)
    {
        var cmd = CreatePackage<PoolPrintPrefabsCommand>();
        var content = new System.Text.StringBuilder(CommandFullName);
        content.Append($" {args}");
        if (json) content.Append(" --json");
        cmd.Content = content.ToString();
        return cmd;
    }
}
