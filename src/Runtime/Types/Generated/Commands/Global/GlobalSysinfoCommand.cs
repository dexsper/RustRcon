using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a summary of the current machine hardware and OS info including CPU, GPU, RAM, and platform</summary>
/// <remarks>Full RCON name: <c>global.sysinfo</c></remarks>
public sealed class GlobalSysinfoCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.sysinfo";

    /// <summary>Creates a new <see cref="GlobalSysinfoCommand"/> command.</summary>
    public static GlobalSysinfoCommand Create()
    {
        var cmd = CreatePackage<GlobalSysinfoCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
