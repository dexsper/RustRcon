using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>profile.perfsnapshot [delay=15, int] [name='Profile', str, no extension, max 32chars] [frames=10, int, max 10] [debug=false, dumps a binary snapshot as well] Will produce a JSON perf snapshot of &lt;frames&gt; that can be viewed in Perfetto or similar tools</summary>
/// <remarks>Full RCON name: <c>profile.perfsnapshot</c></remarks>
public sealed class ProfilePerfsnapshotCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.perfsnapshot";

    /// <summary>Creates a new <see cref="ProfilePerfsnapshotCommand"/> command.</summary>
    public static ProfilePerfsnapshotCommand Create(int delay, string arg1, int frames, bool generateBinary)
    {
        var cmd = CreatePackage<ProfilePerfsnapshotCommand>();
        cmd.Content = $"{CommandFullName} {delay} {arg1} {frames} {generateBinary}";
        return cmd;
    }
}
