using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>chat.say</c>.</summary>
/// <remarks>Full RCON name: <c>chat.say</c></remarks>
public sealed class ChatSayCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "chat.say";

    /// <summary>Creates a new <see cref="ChatSayCommand"/> command.</summary>
    public static ChatSayCommand Create()
    {
        var cmd = CreatePackage<ChatSayCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
