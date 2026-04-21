using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Resets the PlayerState of the given player</summary>
/// <remarks>Full RCON name: <c>player.resetstate</c></remarks>
public sealed class PlayerResetstateCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "player.resetstate";

    /// <summary>Creates a new <see cref="PlayerResetstateCommand"/> command.</summary>
    public static PlayerResetstateCommand Create()
    {
        var cmd = CreatePackage<PlayerResetstateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
