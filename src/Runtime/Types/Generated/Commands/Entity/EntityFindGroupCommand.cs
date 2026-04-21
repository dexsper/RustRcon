using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Lists all networked entities belonging to the given network group ID in a formatted table; admin-only on client</summary>
/// <remarks>Full RCON name: <c>entity.find_group</c></remarks>
public sealed class EntityFindGroupCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "entity.find_group";

    /// <summary>Creates a new <see cref="EntityFindGroupCommand"/> command.</summary>
    public static EntityFindGroupCommand Create()
    {
        var cmd = CreatePackage<EntityFindGroupCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
