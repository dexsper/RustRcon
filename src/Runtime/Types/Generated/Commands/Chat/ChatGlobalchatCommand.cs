using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>chat.globalchat</c>.</summary>
/// <remarks>Full RCON name: <c>chat.globalchat</c></remarks>
public sealed class ChatGlobalchatCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "chat.globalchat";

    /// <summary>Reads the current value of <c>chat.globalchat</c>.</summary>
    public static ChatGlobalchatCommand CreateGet()
    {
        var cmd = CreatePackage<ChatGlobalchatCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>chat.globalchat</c> to <paramref name="value"/>.</summary>
    public static ChatGlobalchatCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ChatGlobalchatCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
