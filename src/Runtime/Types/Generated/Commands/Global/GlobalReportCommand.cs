using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Runs a server performance diagnostic report covering entity counts, memory usage, and active invokes, outputting results to the server console</summary>
/// <remarks>Full RCON name: <c>global.report</c></remarks>
public sealed class GlobalReportCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.report";

    /// <summary>Creates a new <see cref="GlobalReportCommand"/> command.</summary>
    public static GlobalReportCommand Create()
    {
        var cmd = CreatePackage<GlobalReportCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
