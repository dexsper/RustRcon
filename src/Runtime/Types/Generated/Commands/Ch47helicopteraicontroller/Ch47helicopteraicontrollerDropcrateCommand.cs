using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Commands all active CH47 Chinook helicopter AI controllers to drop their cargo crate immediately</summary>
/// <remarks>Full RCON name: <c>ch47helicopteraicontroller.dropcrate</c></remarks>
public sealed class Ch47helicopteraicontrollerDropcrateCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ch47helicopteraicontroller.dropcrate";

    /// <summary>Creates a new <see cref="Ch47helicopteraicontrollerDropcrateCommand"/> command.</summary>
    public static Ch47helicopteraicontrollerDropcrateCommand Create()
    {
        var cmd = CreatePackage<Ch47helicopteraicontrollerDropcrateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
