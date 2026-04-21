using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Removes owner status from the specified Steam64 ID; removes admin flag from the player if currently connected</summary>
/// <remarks>Full RCON name: <c>global.removeowner</c></remarks>
public sealed class GlobalRemoveownerCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.removeowner";

    /// <summary>Creates a new <see cref="GlobalRemoveownerCommand"/> command.</summary>
    public static GlobalRemoveownerCommand Create(SteamId steamId)
    {
        var cmd = CreatePackage<GlobalRemoveownerCommand>();
        cmd.Content = $"{CommandFullName} {steamId}";
        return cmd;
    }
}
