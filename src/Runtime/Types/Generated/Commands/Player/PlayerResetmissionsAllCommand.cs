using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Resets the saved missions progress of all player states on this server (online and offline players). Must be entered as "resetmissions_all Y" to execute.</summary>
/// <remarks>Full RCON name: <c>player.resetmissions_all</c></remarks>
public sealed class PlayerResetmissionsAllCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "player.resetmissions_all";

    /// <summary>Creates a new <see cref="PlayerResetmissionsAllCommand"/> command.</summary>
    public static PlayerResetmissionsAllCommand Create()
    {
        var cmd = CreatePackage<PlayerResetmissionsAllCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
