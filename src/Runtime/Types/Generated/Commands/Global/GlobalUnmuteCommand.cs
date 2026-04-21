using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Removes the chat mute from the specified connected player, allowing them to send messages again</summary>
/// <remarks>Full RCON name: <c>global.unmute</c></remarks>
public sealed class GlobalUnmuteCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.unmute";

    /// <summary>Creates a new <see cref="GlobalUnmuteCommand"/> command.</summary>
    public static GlobalUnmuteCommand Create()
    {
        var cmd = CreatePackage<GlobalUnmuteCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
