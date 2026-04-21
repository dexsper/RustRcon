using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Spawns a server entity by prefab name at a given world position and direction; returns the spawned entity net ID</summary>
/// <remarks>Full RCON name: <c>entity.spawn</c></remarks>
public sealed class EntitySpawnCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "entity.spawn";

    /// <summary>Creates a new <see cref="EntitySpawnCommand"/> command.</summary>
    public static EntitySpawnCommand Create(string arg0, int arg3)
    {
        var cmd = CreatePackage<EntitySpawnCommand>();
        cmd.Content = $"{CommandFullName} {arg0} {arg3}";
        return cmd;
    }
}
