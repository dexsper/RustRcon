using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Dumps a diagnostic snapshot into a numbered diagnostics/ subfolder including LOD group data and other engine diagnostics</summary>
/// <remarks>Full RCON name: <c>global.dump</c></remarks>
public sealed class GlobalDumpCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.dump";

    /// <summary>Creates a new <see cref="GlobalDumpCommand"/> command.</summary>
    public static GlobalDumpCommand Create()
    {
        var cmd = CreatePackage<GlobalDumpCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
