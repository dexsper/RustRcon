using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Enable to allow runtime profiling to persist across restarts</summary>
/// <remarks>Full RCON name: <c>profile.runtime_profiling_persist</c></remarks>
public sealed class ProfileRuntimeProfilingPersistCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.runtime_profiling_persist";

    /// <summary>Reads the current value of <c>profile.runtime_profiling_persist</c>.</summary>
    public static ProfileRuntimeProfilingPersistCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileRuntimeProfilingPersistCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.runtime_profiling_persist</c> to <paramref name="value"/>.</summary>
    public static ProfileRuntimeProfilingPersistCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ProfileRuntimeProfilingPersistCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
