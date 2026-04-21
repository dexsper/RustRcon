using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Print off count of global building entities on the server</summary>
/// <remarks>Full RCON name: <c>render.print_global_entities</c></remarks>
public sealed class RenderPrintGlobalEntitiesCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "render.print_global_entities";

    /// <summary>Creates a new <see cref="RenderPrintGlobalEntitiesCommand"/> command.</summary>
    public static RenderPrintGlobalEntitiesCommand Create()
    {
        var cmd = CreatePackage<RenderPrintGlobalEntitiesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
