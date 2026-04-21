using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>fillcontainer_radius &lt;radius&gt; &lt;optional: category&gt; - Fills containers with random items within a radius, can also specify a category</summary>
/// <remarks>Full RCON name: <c>global.fillcontainer_radius</c></remarks>
public sealed class GlobalFillcontainerRadiusCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.fillcontainer_radius";

    /// <summary>Creates a new <see cref="GlobalFillcontainerRadiusCommand"/> command.</summary>
    public static GlobalFillcontainerRadiusCommand Create(int arg0, string arg1)
    {
        var cmd = CreatePackage<GlobalFillcontainerRadiusCommand>();
        cmd.Content = $"{CommandFullName} {arg0} {arg1}";
        return cmd;
    }
}
