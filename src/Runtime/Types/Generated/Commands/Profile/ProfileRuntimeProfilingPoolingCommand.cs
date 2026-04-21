using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>0 = off, 1 = flush every 5 minutes</summary>
/// <remarks>Full RCON name: <c>profile.runtime_profiling_pooling</c></remarks>
public sealed class ProfileRuntimeProfilingPoolingCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.runtime_profiling_pooling";

    /// <summary>Reads the current value of <c>profile.runtime_profiling_pooling</c>.</summary>
    public static ProfileRuntimeProfilingPoolingCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileRuntimeProfilingPoolingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.runtime_profiling_pooling</c> to <paramref name="value"/>.</summary>
    public static ProfileRuntimeProfilingPoolingCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileRuntimeProfilingPoolingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
