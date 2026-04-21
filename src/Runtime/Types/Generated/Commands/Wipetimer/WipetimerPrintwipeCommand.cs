using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the current wipe timer status including next wipe date, frequency, and time remaining</summary>
/// <remarks>Full RCON name: <c>wipetimer.printwipe</c></remarks>
public sealed class WipetimerPrintwipeCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "wipetimer.printwipe";

    /// <summary>Creates a new <see cref="WipetimerPrintwipeCommand"/> command.</summary>
    public static WipetimerPrintwipeCommand Create()
    {
        var cmd = CreatePackage<WipetimerPrintwipeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
