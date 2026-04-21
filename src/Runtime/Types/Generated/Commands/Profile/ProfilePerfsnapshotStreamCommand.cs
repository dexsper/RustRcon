using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>profile.perfsnapshot_stream [name='Profile', str, no extension, max 32chars] [MainCap=32, int, max 256, buffer size for Main thread in Megabytes] [WorkerCap=8, int, max 256, buffer size for each Worker thread in Megabytes] [debug=false, dumps a binary snapshot as well] Will stream &lt;mainCap&gt;MB worth of data and generate a JSON snapshot that can be viewed in Perfetto or similar tools</summary>
/// <remarks>Full RCON name: <c>profile.perfsnapshot_stream</c></remarks>
public sealed class ProfilePerfsnapshotStreamCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.perfsnapshot_stream";

    /// <summary>Creates a new <see cref="ProfilePerfsnapshotStreamCommand"/> command.</summary>
    public static ProfilePerfsnapshotStreamCommand Create(string arg0, bool generateBinary)
    {
        var cmd = CreatePackage<ProfilePerfsnapshotStreamCommand>();
        cmd.Content = $"{CommandFullName} {arg0} {generateBinary}";
        return cmd;
    }
}
