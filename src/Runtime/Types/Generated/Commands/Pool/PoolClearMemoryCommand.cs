using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Clears all entries from the object memory pool matching the optional name filter; freed pooled objects are garbage collected</summary>
/// <remarks>Full RCON name: <c>pool.clear_memory</c></remarks>
public sealed class PoolClearMemoryCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "pool.clear_memory";

    /// <summary>Creates a new <see cref="PoolClearMemoryCommand"/> command.</summary>
    public static PoolClearMemoryCommand Create(string args)
    {
        var cmd = CreatePackage<PoolClearMemoryCommand>();
        cmd.Content = $"{CommandFullName} {args}";
        return cmd;
    }
}
