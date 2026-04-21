using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Lists the networked entity with the given network entity ID in a formatted table; admin-only on client</summary>
/// <remarks>Full RCON name: <c>entity.find_id</c></remarks>
public sealed class EntityFindIdCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "entity.find_id";

    /// <summary>Creates a new <see cref="EntityFindIdCommand"/> command.</summary>
    public static EntityFindIdCommand Create()
    {
        var cmd = CreatePackage<EntityFindIdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
