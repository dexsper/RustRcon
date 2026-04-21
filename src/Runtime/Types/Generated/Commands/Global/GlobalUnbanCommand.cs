using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Removes the ban for the specified Steam64 ID from the server banlist, allowing the player to reconnect</summary>
/// <remarks>Full RCON name: <c>global.unban</c></remarks>
public sealed class GlobalUnbanCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.unban";

    /// <summary>Creates a new <see cref="GlobalUnbanCommand"/> command.</summary>
    public static GlobalUnbanCommand Create(SteamId steamId)
    {
        var cmd = CreatePackage<GlobalUnbanCommand>();
        cmd.Content = $"{CommandFullName} {steamId}";
        return cmd;
    }
}
