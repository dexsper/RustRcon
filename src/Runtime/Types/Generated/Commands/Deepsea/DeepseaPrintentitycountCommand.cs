using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a breakdown of all entities currently in the deep sea, including totals for players, NPCs, vehicles (by prefab), trees, and metal detector sources</summary>
/// <remarks>Full RCON name: <c>deepsea.printentitycount</c></remarks>
public sealed class DeepseaPrintentitycountCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.printentitycount";

    /// <summary>Creates a new <see cref="DeepseaPrintentitycountCommand"/> command.</summary>
    public static DeepseaPrintentitycountCommand Create()
    {
        var cmd = CreatePackage<DeepseaPrintentitycountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
