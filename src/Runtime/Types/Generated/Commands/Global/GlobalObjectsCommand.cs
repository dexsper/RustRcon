using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints all live Unity Object instances sorted by total memory usage, showing type, instance count, and estimated total size in bytes</summary>
/// <remarks>Full RCON name: <c>global.objects</c></remarks>
public sealed class GlobalObjectsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.objects";

    /// <summary>Creates a new <see cref="GlobalObjectsCommand"/> command.</summary>
    public static GlobalObjectsCommand Create()
    {
        var cmd = CreatePackage<GlobalObjectsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
