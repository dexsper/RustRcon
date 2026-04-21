using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Dumps all available Unity Profiler recorder handles to CSV format showing name, category, unit type, and flags; useful for discovering available performance metrics</summary>
/// <remarks>Full RCON name: <c>profile.dump_profile_recorders</c></remarks>
public sealed class ProfileDumpProfileRecordersCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.dump_profile_recorders";

    /// <summary>Creates a new <see cref="ProfileDumpProfileRecordersCommand"/> command.</summary>
    public static ProfileDumpProfileRecordersCommand Create()
    {
        var cmd = CreatePackage<ProfileDumpProfileRecordersCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
