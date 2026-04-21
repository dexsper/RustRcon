using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, all chat messages are written to the server log file in addition to being broadcast to players</summary>
/// <remarks>Full RCON name: <c>chat.serverlog</c></remarks>
public sealed class ChatServerlogCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "chat.serverlog";

    /// <summary>Reads the current value of <c>chat.serverlog</c>.</summary>
    public static ChatServerlogCommand CreateGet()
    {
        var cmd = CreatePackage<ChatServerlogCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>chat.serverlog</c> to <paramref name="value"/>.</summary>
    public static ChatServerlogCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ChatServerlogCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
