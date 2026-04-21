using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Renders a PNG of the current map's underwater labs, for a specific floor</summary>
/// <remarks>Full RCON name: <c>world.renderlabs</c></remarks>
public sealed class WorldRenderlabsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "world.renderlabs";

    /// <summary>Creates a new <see cref="WorldRenderlabsCommand"/> command.</summary>
    public static WorldRenderlabsCommand Create(int value)
    {
        var cmd = CreatePackage<WorldRenderlabsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
