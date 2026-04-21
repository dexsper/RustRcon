using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Clears the custom name UGC from all vending machines whose content string contains the given search text (case/symbol insensitive)</summary>
/// <remarks>Full RCON name: <c>global.clearvendingmachinenamescontaining</c></remarks>
public sealed class GlobalClearvendingmachinenamescontainingCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.clearvendingmachinenamescontaining";

    /// <summary>Creates a new <see cref="GlobalClearvendingmachinenamescontainingCommand"/> command.</summary>
    public static GlobalClearvendingmachinenamescontainingCommand Create(string args)
    {
        var cmd = CreatePackage<GlobalClearvendingmachinenamescontainingCommand>();
        cmd.Content = $"{CommandFullName} {args}";
        return cmd;
    }
}
