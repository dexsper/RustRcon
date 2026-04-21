using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Clears all cached prefab instances from the prefab pool matching the optional filter, across client, server, and generic pools</summary>
/// <remarks>Full RCON name: <c>pool.clear_prefabs</c></remarks>
public sealed class PoolClearPrefabsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "pool.clear_prefabs";

    /// <summary>Creates a new <see cref="PoolClearPrefabsCommand"/> command.</summary>
    public static PoolClearPrefabsCommand Create(string args)
    {
        var cmd = CreatePackage<PoolClearPrefabsCommand>();
        cmd.Content = $"{CommandFullName} {args}";
        return cmd;
    }
}
