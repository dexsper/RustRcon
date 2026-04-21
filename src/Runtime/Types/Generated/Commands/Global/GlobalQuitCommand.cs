using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Quits the application cleanly with no arguments; rejects calls with arguments to prevent accidental exit; in the editor exits play mode</summary>
/// <remarks>Full RCON name: <c>global.quit</c></remarks>
public sealed class GlobalQuitCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.quit";

    /// <summary>Creates a new <see cref="GlobalQuitCommand"/> command.</summary>
    public static GlobalQuitCommand Create()
    {
        var cmd = CreatePackage<GlobalQuitCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
