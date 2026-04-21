using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Draws flat wireframe boxes in the world showing world bounds (red), terrain margin (yellow), deep sea bounds (cyan), and portal bounds (green/magenta) for the given duration in seconds</summary>
/// <remarks>Full RCON name: <c>world.drawbounds</c></remarks>
public sealed class WorldDrawboundsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "world.drawbounds";

    /// <summary>Creates a new <see cref="WorldDrawboundsCommand"/> command.</summary>
    public static WorldDrawboundsCommand Create()
    {
        var cmd = CreatePackage<WorldDrawboundsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
