using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>chat.localsay</c>.</summary>
/// <remarks>Full RCON name: <c>chat.localsay</c></remarks>
public sealed class ChatLocalsayCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "chat.localsay";

    /// <summary>Creates a new <see cref="ChatLocalsayCommand"/> command.</summary>
    public static ChatLocalsayCommand Create()
    {
        var cmd = CreatePackage<ChatLocalsayCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
