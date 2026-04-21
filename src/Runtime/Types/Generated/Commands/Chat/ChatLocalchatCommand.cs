using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>chat.localchat</c>.</summary>
/// <remarks>Full RCON name: <c>chat.localchat</c></remarks>
public sealed class ChatLocalchatCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "chat.localchat";

    /// <summary>Reads the current value of <c>chat.localchat</c>.</summary>
    public static ChatLocalchatCommand CreateGet()
    {
        var cmd = CreatePackage<ChatLocalchatCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>chat.localchat</c> to <paramref name="value"/>.</summary>
    public static ChatLocalchatCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ChatLocalchatCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
