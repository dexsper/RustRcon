using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Applies a small positional nudge to an entity by net ID, useful for unsticking entities that are clipping into geometry</summary>
/// <remarks>Full RCON name: <c>entity.nudge</c></remarks>
public sealed class EntityNudgeCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "entity.nudge";

    /// <summary>Creates a new <see cref="EntityNudgeCommand"/> command.</summary>
    public static EntityNudgeCommand Create()
    {
        var cmd = CreatePackage<EntityNudgeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
