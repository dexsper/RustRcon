using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Same as gesture_radius but excludes the calling admin from the gesture; forces all other players within the radius to perform a random gesture from the provided list</summary>
/// <remarks>Full RCON name: <c>player.gesture_radius_notme</c></remarks>
public sealed class PlayerGestureRadiusNotmeCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "player.gesture_radius_notme";

    /// <summary>Creates a new <see cref="PlayerGestureRadiusNotmeCommand"/> command.</summary>
    public static PlayerGestureRadiusNotmeCommand Create()
    {
        var cmd = CreatePackage<PlayerGestureRadiusNotmeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
