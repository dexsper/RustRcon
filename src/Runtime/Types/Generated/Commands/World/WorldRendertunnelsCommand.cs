using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Renders a PNG of the current map's tunnel network</summary>
/// <remarks>Full RCON name: <c>world.rendertunnels</c></remarks>
public sealed class WorldRendertunnelsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "world.rendertunnels";

    /// <summary>Creates a new <see cref="WorldRendertunnelsCommand"/> command.</summary>
    public static WorldRendertunnelsCommand Create()
    {
        var cmd = CreatePackage<WorldRendertunnelsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
