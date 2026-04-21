using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Starts recording a Unity Profiler binary log to a timestamped file in the profile/ folder; requires ENABLE_PROFILER build flag</summary>
/// <remarks>Full RCON name: <c>profile.start</c></remarks>
public sealed class ProfileStartCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.start";

    /// <summary>Creates a new <see cref="ProfileStartCommand"/> command.</summary>
    public static ProfileStartCommand Create()
    {
        var cmd = CreatePackage<ProfileStartCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
