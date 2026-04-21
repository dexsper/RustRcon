using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Remove all players from the AIs ignore list.</summary>
/// <remarks>Full RCON name: <c>ai.clearignoredplayers</c></remarks>
public sealed class AiClearignoredplayersCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.clearignoredplayers";

    /// <summary>Creates a new <see cref="AiClearignoredplayersCommand"/> command.</summary>
    public static AiClearignoredplayersCommand Create()
    {
        var cmd = CreatePackage<AiClearignoredplayersCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
