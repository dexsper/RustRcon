using RustRcon.Types;
using RustRcon.Types.Commands.Base;
using RustRcon.Generated.Dtos;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>chat.search</c>.</summary>
/// <remarks>Full RCON name: <c>chat.search</c></remarks>
public sealed class ChatSearchCommand : BaseCallCommand<ChatEntry[]>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "chat.search";

    /// <summary>Creates a new <see cref="ChatSearchCommand"/> command.</summary>
    public static ChatSearchCommand Create(string search)
    {
        var cmd = CreatePackage<ChatSearchCommand>();
        cmd.Content = $"{CommandFullName} {search}";
        return cmd;
    }
}
