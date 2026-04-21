using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>0 = off, 1 = basic, 2 = everything. This will reset all profiling convars, however they can be modified afterwards</summary>
/// <remarks>Full RCON name: <c>profile.runtime_profiling</c></remarks>
public sealed class ProfileRuntimeProfilingCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.runtime_profiling";

    /// <summary>Reads the current value of <c>profile.runtime_profiling</c>.</summary>
    public static ProfileRuntimeProfilingCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileRuntimeProfilingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.runtime_profiling</c> to <paramref name="value"/>.</summary>
    public static ProfileRuntimeProfilingCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileRuntimeProfilingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
