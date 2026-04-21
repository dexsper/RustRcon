using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Forces all players within a given radius (including the caller) to play one of the specified gesture names chosen at random; admin only; args: radius gesture1 [gesture2...]</summary>
/// <remarks>Full RCON name: <c>player.gesture_radius</c></remarks>
public sealed class PlayerGestureRadiusCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "player.gesture_radius";

    /// <summary>Creates a new <see cref="PlayerGestureRadiusCommand"/> command.</summary>
    public static PlayerGestureRadiusCommand Create()
    {
        var cmd = CreatePackage<PlayerGestureRadiusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
