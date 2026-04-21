using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The time it takes for a NPC to fully notice a player standing right in front of them, in seconds.</summary>
/// <remarks>Full RCON name: <c>ai.setnpcreactiontime</c></remarks>
public sealed class AiSetnpcreactiontimeCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.setnpcreactiontime";

    /// <summary>Creates a new <see cref="AiSetnpcreactiontimeCommand"/> command.</summary>
    public static AiSetnpcreactiontimeCommand Create()
    {
        var cmd = CreatePackage<AiSetnpcreactiontimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
