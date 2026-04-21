using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Mutes the specified connected player preventing them from using chat; optionally accepts a mute expiry timestamp for temporary mutes</summary>
/// <remarks>Full RCON name: <c>global.mute</c></remarks>
public sealed class GlobalMuteCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.mute";

    /// <summary>Creates a new <see cref="GlobalMuteCommand"/> command.</summary>
    public static GlobalMuteCommand Create()
    {
        var cmd = CreatePackage<GlobalMuteCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
