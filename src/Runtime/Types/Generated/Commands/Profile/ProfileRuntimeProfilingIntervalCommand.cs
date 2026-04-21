using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>profile.runtime_profiling_interval</c>.</summary>
/// <remarks>Full RCON name: <c>profile.runtime_profiling_interval</c></remarks>
public sealed class ProfileRuntimeProfilingIntervalCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.runtime_profiling_interval";

    /// <summary>Reads the current value of <c>profile.runtime_profiling_interval</c>.</summary>
    public static ProfileRuntimeProfilingIntervalCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileRuntimeProfilingIntervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.runtime_profiling_interval</c> to <paramref name="value"/>.</summary>
    public static ProfileRuntimeProfilingIntervalCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileRuntimeProfilingIntervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
