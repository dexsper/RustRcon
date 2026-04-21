using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>0 = off, 1 = stats per frame, 2 = stats per method</summary>
/// <remarks>Full RCON name: <c>profile.profiling_fixed_invokes</c></remarks>
public sealed class ProfileProfilingFixedInvokesCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.profiling_fixed_invokes";

    /// <summary>Reads the current value of <c>profile.profiling_fixed_invokes</c>.</summary>
    public static ProfileProfilingFixedInvokesCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileProfilingFixedInvokesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.profiling_fixed_invokes</c> to <paramref name="value"/>.</summary>
    public static ProfileProfilingFixedInvokesCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileProfilingFixedInvokesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
