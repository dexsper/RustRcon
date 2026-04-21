using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>chat.teamsay</c>.</summary>
/// <remarks>Full RCON name: <c>chat.teamsay</c></remarks>
public sealed class ChatTeamsayCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "chat.teamsay";

    /// <summary>Creates a new <see cref="ChatTeamsayCommand"/> command.</summary>
    public static ChatTeamsayCommand Create()
    {
        var cmd = CreatePackage<ChatTeamsayCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
