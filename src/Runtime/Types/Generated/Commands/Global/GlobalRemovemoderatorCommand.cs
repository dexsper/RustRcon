using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Removes moderator status from the specified Steam64 ID; removes admin flag from the player if currently connected</summary>
/// <remarks>Full RCON name: <c>global.removemoderator</c></remarks>
public sealed class GlobalRemovemoderatorCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.removemoderator";

    /// <summary>Creates a new <see cref="GlobalRemovemoderatorCommand"/> command.</summary>
    public static GlobalRemovemoderatorCommand Create(SteamId steamId)
    {
        var cmd = CreatePackage<GlobalRemovemoderatorCommand>();
        cmd.Content = $"{CommandFullName} {steamId}";
        return cmd;
    }
}
