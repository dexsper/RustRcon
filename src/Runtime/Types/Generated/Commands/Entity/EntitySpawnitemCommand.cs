using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Spawns a dropped item entity server-side by item short name at a given world position</summary>
/// <remarks>Full RCON name: <c>entity.spawnitem</c></remarks>
public sealed class EntitySpawnitemCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "entity.spawnitem";

    /// <summary>Creates a new <see cref="EntitySpawnitemCommand"/> command.</summary>
    public static EntitySpawnitemCommand Create(string args)
    {
        var cmd = CreatePackage<EntitySpawnitemCommand>();
        cmd.Content = $"{CommandFullName} {args}";
        return cmd;
    }
}
