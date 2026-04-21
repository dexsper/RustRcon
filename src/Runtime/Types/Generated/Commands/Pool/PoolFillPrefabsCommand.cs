using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Pre-warms the prefab pool by instantiating and pooling prefabs matching the optional filter up to the given count override</summary>
/// <remarks>Full RCON name: <c>pool.fill_prefabs</c></remarks>
public sealed class PoolFillPrefabsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "pool.fill_prefabs";

    /// <summary>Creates a new <see cref="PoolFillPrefabsCommand"/> command.</summary>
    public static PoolFillPrefabsCommand Create(string arg0, int arg1)
    {
        var cmd = CreatePackage<PoolFillPrefabsCommand>();
        cmd.Content = $"{CommandFullName} {arg0} {arg1}";
        return cmd;
    }
}
