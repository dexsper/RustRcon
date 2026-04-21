using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Print off count of trees to ensure server sent them all</summary>
/// <remarks>Full RCON name: <c>render.tree_entities</c></remarks>
public sealed class RenderTreeEntitiesCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "render.tree_entities";

    /// <summary>Creates a new <see cref="RenderTreeEntitiesCommand"/> command.</summary>
    public static RenderTreeEntitiesCommand Create()
    {
        var cmd = CreatePackage<RenderTreeEntitiesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
