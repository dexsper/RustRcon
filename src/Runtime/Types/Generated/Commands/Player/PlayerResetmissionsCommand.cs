using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Resets the saved missions progress of the given player</summary>
/// <remarks>Full RCON name: <c>player.resetmissions</c></remarks>
public sealed class PlayerResetmissionsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "player.resetmissions";

    /// <summary>Creates a new <see cref="PlayerResetmissionsCommand"/> command.</summary>
    public static PlayerResetmissionsCommand Create()
    {
        var cmd = CreatePackage<PlayerResetmissionsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
