using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Adds the specified Steam64 ID as a server moderator with optional name and reason; grants admin flag to the player if connected</summary>
/// <remarks>Full RCON name: <c>global.moderatorid</c></remarks>
public sealed class GlobalModeratoridCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.moderatorid";

    /// <summary>Creates a new <see cref="GlobalModeratoridCommand"/> command.</summary>
    public static GlobalModeratoridCommand Create(SteamId steamId, string arg1, string string2)
    {
        var cmd = CreatePackage<GlobalModeratoridCommand>();
        cmd.Content = $"{CommandFullName} {steamId} {arg1} {string2}";
        return cmd;
    }
}
