using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Renders a high resolution PNG of the current map</summary>
/// <remarks>Full RCON name: <c>world.rendermap</c></remarks>
public sealed class WorldRendermapCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "world.rendermap";

    /// <summary>Creates a new <see cref="WorldRendermapCommand"/> command.</summary>
    public static WorldRendermapCommand Create(float value)
    {
        var cmd = CreatePackage<WorldRendermapCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
