using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Triggers an immediate full managed garbage collection pass; useful after large allocations for memory profiling</summary>
/// <remarks>Full RCON name: <c>gc.collect</c></remarks>
public sealed class GcCollectCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "gc.collect";

    /// <summary>Creates a new <see cref="GcCollectCommand"/> command.</summary>
    public static GcCollectCommand Create()
    {
        var cmd = CreatePackage<GcCollectCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
