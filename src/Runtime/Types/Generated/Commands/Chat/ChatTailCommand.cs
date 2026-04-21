using RustRcon.Types;
using RustRcon.Types.Commands.Base;
using RustRcon.Generated.Dtos;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>chat.tail</c>.</summary>
/// <remarks>Full RCON name: <c>chat.tail</c></remarks>
public sealed class ChatTailCommand : BaseCallCommand<ChatEntry[]>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "chat.tail";

    /// <summary>Creates a new <see cref="ChatTailCommand"/> command.</summary>
    public static ChatTailCommand Create(int value)
    {
        var cmd = CreatePackage<ChatTailCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
