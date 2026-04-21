using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Spawns a grid of server entities by prefab name centred at a position; useful for stress-testing entity counts</summary>
/// <remarks>Full RCON name: <c>entity.spawngrid</c></remarks>
public sealed class EntitySpawngridCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "entity.spawngrid";

    /// <summary>Creates a new <see cref="EntitySpawngridCommand"/> command.</summary>
    public static EntitySpawngridCommand Create(string arg0, int arg1, int arg2, int arg3)
    {
        var cmd = CreatePackage<EntitySpawngridCommand>();
        cmd.Content = $"{CommandFullName} {arg0} {arg1} {arg2} {arg3}";
        return cmd;
    }
}
