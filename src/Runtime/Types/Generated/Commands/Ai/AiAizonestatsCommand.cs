using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the total count of registered AIInformationZone instances on the server</summary>
/// <remarks>Full RCON name: <c>ai.aizonestats</c></remarks>
public sealed class AiAizonestatsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.aizonestats";

    /// <summary>Creates a new <see cref="AiAizonestatsCommand"/> command.</summary>
    public static AiAizonestatsCommand Create()
    {
        var cmd = CreatePackage<AiAizonestatsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
