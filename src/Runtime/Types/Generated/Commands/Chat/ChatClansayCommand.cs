using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>chat.clansay</c>.</summary>
/// <remarks>Full RCON name: <c>chat.clansay</c></remarks>
public sealed class ChatClansayCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "chat.clansay";

    /// <summary>Creates a new <see cref="ChatClansayCommand"/> command.</summary>
    public static ChatClansayCommand Create()
    {
        var cmd = CreatePackage<ChatClansayCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
