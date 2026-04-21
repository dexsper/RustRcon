using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the current game version string to the console, including build number and branch</summary>
/// <remarks>Full RCON name: <c>global.version</c></remarks>
public sealed class GlobalVersionCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.version";

    /// <summary>Creates a new <see cref="GlobalVersionCommand"/> command.</summary>
    public static GlobalVersionCommand Create()
    {
        var cmd = CreatePackage<GlobalVersionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
