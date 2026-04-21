using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a table of all registered telephone entities showing their number, directory name, and world position</summary>
/// <remarks>Full RCON name: <c>telephonemanager.printallphones</c></remarks>
public sealed class TelephonemanagerPrintallphonesCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "telephonemanager.printallphones";

    /// <summary>Creates a new <see cref="TelephonemanagerPrintallphonesCommand"/> command.</summary>
    public static TelephonemanagerPrintallphonesCommand Create()
    {
        var cmd = CreatePackage<TelephonemanagerPrintallphonesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
