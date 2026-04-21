using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Lists all networked entities whose status string contains the given filter text in a formatted table; admin-only on client</summary>
/// <remarks>Full RCON name: <c>entity.find_status</c></remarks>
public sealed class EntityFindStatusCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "entity.find_status";

    /// <summary>Creates a new <see cref="EntityFindStatusCommand"/> command.</summary>
    public static EntityFindStatusCommand Create()
    {
        var cmd = CreatePackage<EntityFindStatusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
