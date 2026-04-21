using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Whether emoji ownership is checked server side. Could be performance draining in high chat volumes</summary>
/// <remarks>Full RCON name: <c>server.emojiownershipcheck</c></remarks>
public sealed class ServerEmojiownershipcheckCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.emojiownershipcheck";

    /// <summary>Reads the current value of <c>server.emojiownershipcheck</c>.</summary>
    public static ServerEmojiownershipcheckCommand CreateGet()
    {
        var cmd = CreatePackage<ServerEmojiownershipcheckCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.emojiownershipcheck</c> to <paramref name="value"/>.</summary>
    public static ServerEmojiownershipcheckCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerEmojiownershipcheckCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
