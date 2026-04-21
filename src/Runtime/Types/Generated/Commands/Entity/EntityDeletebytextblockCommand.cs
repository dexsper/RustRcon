using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Destroy all entities created by users in the provided text block (can use with copied results from ent auth)</summary>
/// <remarks>Full RCON name: <c>entity.deletebytextblock</c></remarks>
public sealed class EntityDeletebytextblockCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "entity.deletebytextblock";

    /// <summary>Creates a new <see cref="EntityDeletebytextblockCommand"/> command.</summary>
    public static EntityDeletebytextblockCommand Create(string args)
    {
        var cmd = CreatePackage<EntityDeletebytextblockCommand>();
        cmd.Content = $"{CommandFullName} {args}";
        return cmd;
    }
}
