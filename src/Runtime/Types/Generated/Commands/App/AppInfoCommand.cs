using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints current server info including name, level, connected players, max players, and network address to the console</summary>
/// <remarks>Full RCON name: <c>app.info</c></remarks>
public sealed class AppInfoCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "app.info";

    /// <summary>Creates a new <see cref="AppInfoCommand"/> command.</summary>
    public static AppInfoCommand Create()
    {
        var cmd = CreatePackage<AppInfoCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
