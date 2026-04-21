using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Lists all GameObjects in the current hierarchy context, similar to the Unix ls command; used for navigating the scene hierarchy from the console</summary>
/// <remarks>Full RCON name: <c>hierarchy.ls</c></remarks>
public sealed class HierarchyLsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "hierarchy.ls";

    /// <summary>Creates a new <see cref="HierarchyLsCommand"/> command.</summary>
    public static HierarchyLsCommand Create()
    {
        var cmd = CreatePackage<HierarchyLsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
