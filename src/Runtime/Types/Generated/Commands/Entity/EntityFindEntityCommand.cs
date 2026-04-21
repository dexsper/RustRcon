using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Lists all networked entities whose prefab path contains the given filter string in a formatted table; admin-only on client</summary>
/// <remarks>Full RCON name: <c>entity.find_entity</c></remarks>
public sealed class EntityFindEntityCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "entity.find_entity";

    /// <summary>Creates a new <see cref="EntityFindEntityCommand"/> command.</summary>
    public static EntityFindEntityCommand Create()
    {
        var cmd = CreatePackage<EntityFindEntityCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
