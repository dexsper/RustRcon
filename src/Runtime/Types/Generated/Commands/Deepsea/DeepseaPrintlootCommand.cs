using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a breakdown of all loot containers, trees, and ore nodes currently present in the deep sea, grouped by prefab name with counts</summary>
/// <remarks>Full RCON name: <c>deepsea.printloot</c></remarks>
public sealed class DeepseaPrintlootCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.printloot";

    /// <summary>Creates a new <see cref="DeepseaPrintlootCommand"/> command.</summary>
    public static DeepseaPrintlootCommand Create()
    {
        var cmd = CreatePackage<DeepseaPrintlootCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
