using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>chat.cardgamesay</c>.</summary>
/// <remarks>Full RCON name: <c>chat.cardgamesay</c></remarks>
public sealed class ChatCardgamesayCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "chat.cardgamesay";

    /// <summary>Creates a new <see cref="ChatCardgamesayCommand"/> command.</summary>
    public static ChatCardgamesayCommand Create()
    {
        var cmd = CreatePackage<ChatCardgamesayCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
