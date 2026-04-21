using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Takes a full Unity Memory Profiler snapshot capturing all managed, native, and graphics memory and saves it as a timestamped .snap file in profile/</summary>
/// <remarks>Full RCON name: <c>memsnap.full</c></remarks>
public sealed class MemsnapFullCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "memsnap.full";

    /// <summary>Creates a new <see cref="MemsnapFullCommand"/> command.</summary>
    public static MemsnapFullCommand Create()
    {
        var cmd = CreatePackage<MemsnapFullCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
