using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>clearcontainer_radius &lt;radius&gt;: Removes all items inside a container within a radius</summary>
/// <remarks>Full RCON name: <c>global.clearcontainer_radius</c></remarks>
public sealed class GlobalClearcontainerRadiusCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.clearcontainer_radius";

    /// <summary>Creates a new <see cref="GlobalClearcontainerRadiusCommand"/> command.</summary>
    public static GlobalClearcontainerRadiusCommand Create(int value)
    {
        var cmd = CreatePackage<GlobalClearcontainerRadiusCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
