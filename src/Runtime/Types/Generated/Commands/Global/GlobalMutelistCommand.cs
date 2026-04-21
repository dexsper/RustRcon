using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Print a list of currently muted players</summary>
/// <remarks>Full RCON name: <c>global.mutelist</c></remarks>
public sealed class GlobalMutelistCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.mutelist";

    /// <summary>Creates a new <see cref="GlobalMutelistCommand"/> command.</summary>
    public static GlobalMutelistCommand Create()
    {
        var cmd = CreatePackage<GlobalMutelistCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
