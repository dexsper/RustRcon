using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Show user info for players on server in range of the supplied player (eg. Jim 50)</summary>
/// <remarks>Full RCON name: <c>global.usersinrangeofplayer</c></remarks>
public sealed class GlobalUsersinrangeofplayerCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.usersinrangeofplayer";

    /// <summary>Creates a new <see cref="GlobalUsersinrangeofplayerCommand"/> command.</summary>
    public static GlobalUsersinrangeofplayerCommand Create(float range)
    {
        var cmd = CreatePackage<GlobalUsersinrangeofplayerCommand>();
        cmd.Content = $"{CommandFullName} {range}";
        return cmd;
    }
}
