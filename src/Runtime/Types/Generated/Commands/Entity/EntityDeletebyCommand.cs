using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Destroy all entities created by provided users (separate users by space)</summary>
/// <remarks>Full RCON name: <c>entity.deleteby</c></remarks>
public sealed class EntityDeletebyCommand : BaseCallCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "entity.deleteby";

    /// <summary>Creates a new <see cref="EntityDeletebyCommand"/> command.</summary>
    public static EntityDeletebyCommand Create()
    {
        var cmd = CreatePackage<EntityDeletebyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
