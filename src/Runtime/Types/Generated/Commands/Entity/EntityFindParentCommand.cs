using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Lists all networked entities that have the given network entity ID as their parent in a formatted table; admin-only on client</summary>
/// <remarks>Full RCON name: <c>entity.find_parent</c></remarks>
public sealed class EntityFindParentCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "entity.find_parent";

    /// <summary>Creates a new <see cref="EntityFindParentCommand"/> command.</summary>
    public static EntityFindParentCommand Create()
    {
        var cmd = CreatePackage<EntityFindParentCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
