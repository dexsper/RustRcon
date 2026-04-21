using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Record execution time of ObjectWorkQueues per frame</summary>
/// <remarks>Full RCON name: <c>profile.profiling_work_queue</c></remarks>
public sealed class ProfileProfilingWorkQueueCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.profiling_work_queue";

    /// <summary>Reads the current value of <c>profile.profiling_work_queue</c>.</summary>
    public static ProfileProfilingWorkQueueCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileProfilingWorkQueueCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.profiling_work_queue</c> to <paramref name="value"/>.</summary>
    public static ProfileProfilingWorkQueueCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ProfileProfilingWorkQueueCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
