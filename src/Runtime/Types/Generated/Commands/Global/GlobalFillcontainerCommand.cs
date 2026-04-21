using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>fillcontainer &lt;optional: category&gt; - Fills the container you are looking at with random items, can also specify a category (ammunition, weapon etc.)</summary>
/// <remarks>Full RCON name: <c>global.fillcontainer</c></remarks>
public sealed class GlobalFillcontainerCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.fillcontainer";

    /// <summary>Creates a new <see cref="GlobalFillcontainerCommand"/> command.</summary>
    public static GlobalFillcontainerCommand Create(string args)
    {
        var cmd = CreatePackage<GlobalFillcontainerCommand>();
        cmd.Content = $"{CommandFullName} {args}";
        return cmd;
    }
}
