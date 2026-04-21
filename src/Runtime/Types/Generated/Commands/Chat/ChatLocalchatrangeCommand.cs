using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum distance in metres within which local chat messages are visible to nearby players; messages from beyond this range are not received</summary>
/// <remarks>Full RCON name: <c>chat.localchatrange</c></remarks>
public sealed class ChatLocalchatrangeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "chat.localchatrange";

    /// <summary>Reads the current value of <c>chat.localchatrange</c>.</summary>
    public static ChatLocalchatrangeCommand CreateGet()
    {
        var cmd = CreatePackage<ChatLocalchatrangeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>chat.localchatrange</c> to <paramref name="value"/>.</summary>
    public static ChatLocalchatrangeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ChatLocalchatrangeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
