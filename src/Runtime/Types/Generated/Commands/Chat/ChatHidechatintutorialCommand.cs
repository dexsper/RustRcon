using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>chat.hidechatintutorial</c>.</summary>
/// <remarks>Full RCON name: <c>chat.hidechatintutorial</c></remarks>
public sealed class ChatHidechatintutorialCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "chat.hidechatintutorial";

    /// <summary>Reads the current value of <c>chat.hidechatintutorial</c>.</summary>
    public static ChatHidechatintutorialCommand CreateGet()
    {
        var cmd = CreatePackage<ChatHidechatintutorialCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>chat.hidechatintutorial</c> to <paramref name="value"/>.</summary>
    public static ChatHidechatintutorialCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ChatHidechatintutorialCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
