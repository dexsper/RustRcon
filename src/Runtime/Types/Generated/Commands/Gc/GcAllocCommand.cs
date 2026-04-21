using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Allocates a byte array of the given size (default 1 MB) as a GC pressure test; useful for profiling memory allocation throughput</summary>
/// <remarks>Full RCON name: <c>gc.alloc</c></remarks>
public sealed class GcAllocCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "gc.alloc";

    /// <summary>Creates a new <see cref="GcAllocCommand"/> command.</summary>
    public static GcAllocCommand Create()
    {
        var cmd = CreatePackage<GcAllocCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
