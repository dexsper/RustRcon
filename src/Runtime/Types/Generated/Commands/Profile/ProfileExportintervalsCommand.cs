using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Interval in seconds between automatic exports of server profiler data to disk; lower values provide more frequent snapshots at a higher I/O cost</summary>
/// <remarks>Full RCON name: <c>profile.exportintervals</c></remarks>
public sealed class ProfileExportintervalsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.exportintervals";

    /// <summary>Reads the current value of <c>profile.exportintervals</c>.</summary>
    public static ProfileExportintervalsCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileExportintervalsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.exportintervals</c> to <paramref name="value"/>.</summary>
    public static ProfileExportintervalsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileExportintervalsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
