using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How often to flush pooling stats in seconds</summary>
/// <remarks>Full RCON name: <c>profile.runtime_profiling_pool_flush_interval</c></remarks>
public sealed class ProfileRuntimeProfilingPoolFlushIntervalCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.runtime_profiling_pool_flush_interval";

    /// <summary>Reads the current value of <c>profile.runtime_profiling_pool_flush_interval</c>.</summary>
    public static ProfileRuntimeProfilingPoolFlushIntervalCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileRuntimeProfilingPoolFlushIntervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.runtime_profiling_pool_flush_interval</c> to <paramref name="value"/>.</summary>
    public static ProfileRuntimeProfilingPoolFlushIntervalCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileRuntimeProfilingPoolFlushIntervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
