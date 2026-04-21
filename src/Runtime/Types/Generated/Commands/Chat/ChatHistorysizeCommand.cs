using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Number of messages to keep in memory for chat history</summary>
/// <remarks>Full RCON name: <c>chat.historysize</c></remarks>
public sealed class ChatHistorysizeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "chat.historysize";

    /// <summary>Reads the current value of <c>chat.historysize</c>.</summary>
    public static ChatHistorysizeCommand CreateGet()
    {
        var cmd = CreatePackage<ChatHistorysizeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>chat.historysize</c> to <paramref name="value"/>.</summary>
    public static ChatHistorysizeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ChatHistorysizeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
