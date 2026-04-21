using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Clears all radio station data set by the given Steam64 ID from all deployed and held boomboxes on the server</summary>
/// <remarks>Full RCON name: <c>boombox.clearradiobyuser</c></remarks>
public sealed class BoomboxClearradiobyuserCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boombox.clearradiobyuser";

    /// <summary>Creates a new <see cref="BoomboxClearradiobyuserCommand"/> command.</summary>
    public static BoomboxClearradiobyuserCommand Create()
    {
        var cmd = CreatePackage<BoomboxClearradiobyuserCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
