using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Exports the current prefab pool contents to a prefabs.csv file listing pool ID, prefab short name, and instance count</summary>
/// <remarks>Full RCON name: <c>pool.export_prefabs</c></remarks>
public sealed class PoolExportPrefabsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "pool.export_prefabs";

    /// <summary>Creates a new <see cref="PoolExportPrefabsCommand"/> command.</summary>
    public static PoolExportPrefabsCommand Create(string args)
    {
        var cmd = CreatePackage<PoolExportPrefabsCommand>();
        cmd.Content = $"{CommandFullName} {args}";
        return cmd;
    }
}
