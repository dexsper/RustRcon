using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Toggles the debug info overlay for an entity by net ID, showing position, velocity, health, and network state in the world</summary>
/// <remarks>Full RCON name: <c>entity.debug_toggle</c></remarks>
public sealed class EntityDebugToggleCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "entity.debug_toggle";

    /// <summary>Creates a new <see cref="EntityDebugToggleCommand"/> command.</summary>
    public static EntityDebugToggleCommand Create()
    {
        var cmd = CreatePackage<EntityDebugToggleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
