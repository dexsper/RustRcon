using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Print a lost of all the players in the AI ignore list.</summary>
/// <remarks>Full RCON name: <c>ai.printignoredplayers</c></remarks>
public sealed class AiPrintignoredplayersCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.printignoredplayers";

    /// <summary>Creates a new <see cref="AiPrintignoredplayersCommand"/> command.</summary>
    public static AiPrintignoredplayersCommand Create()
    {
        var cmd = CreatePackage<AiPrintignoredplayersCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
