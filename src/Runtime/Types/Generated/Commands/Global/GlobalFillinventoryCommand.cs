using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>fillinventory &lt;optional: category&gt; - Fills your inventory with random items, can also specify a category (ammunition, weapon etc.)</summary>
/// <remarks>Full RCON name: <c>global.fillinventory</c></remarks>
public sealed class GlobalFillinventoryCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.fillinventory";

    /// <summary>Creates a new <see cref="GlobalFillinventoryCommand"/> command.</summary>
    public static GlobalFillinventoryCommand Create(string args)
    {
        var cmd = CreatePackage<GlobalFillinventoryCommand>();
        cmd.Content = $"{CommandFullName} {args}";
        return cmd;
    }
}
