using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Clears all cached entries from the asset pool matching the optional name filter</summary>
/// <remarks>Full RCON name: <c>pool.clear_assets</c></remarks>
public sealed class PoolClearAssetsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "pool.clear_assets";

    /// <summary>Creates a new <see cref="PoolClearAssetsCommand"/> command.</summary>
    public static PoolClearAssetsCommand Create(string args)
    {
        var cmd = CreatePackage<PoolClearAssetsCommand>();
        cmd.Content = $"{CommandFullName} {args}";
        return cmd;
    }
}
