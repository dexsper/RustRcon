using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Stops the active Unity Profiler binary log recording and finalises the file</summary>
/// <remarks>Full RCON name: <c>profile.stop</c></remarks>
public sealed class ProfileStopCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.stop";

    /// <summary>Creates a new <see cref="ProfileStopCommand"/> command.</summary>
    public static ProfileStopCommand Create()
    {
        var cmd = CreatePackage<ProfileStopCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
