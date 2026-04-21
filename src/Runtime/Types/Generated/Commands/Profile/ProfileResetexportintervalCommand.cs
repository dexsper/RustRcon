using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Resets the profiler export interval timer, causing the next export to happen after a full ExportIntervalS from now</summary>
/// <remarks>Full RCON name: <c>profile.resetexportinterval</c></remarks>
public sealed class ProfileResetexportintervalCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.resetexportinterval";

    /// <summary>Creates a new <see cref="ProfileResetexportintervalCommand"/> command.</summary>
    public static ProfileResetexportintervalCommand Create()
    {
        var cmd = CreatePackage<ProfileResetexportintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
