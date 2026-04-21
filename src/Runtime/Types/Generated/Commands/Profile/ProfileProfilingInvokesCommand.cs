using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>0 = off, 1 = stats per frame, 2 = stats per method</summary>
/// <remarks>Full RCON name: <c>profile.profiling_invokes</c></remarks>
public sealed class ProfileProfilingInvokesCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.profiling_invokes";

    /// <summary>Reads the current value of <c>profile.profiling_invokes</c>.</summary>
    public static ProfileProfilingInvokesCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileProfilingInvokesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.profiling_invokes</c> to <paramref name="value"/>.</summary>
    public static ProfileProfilingInvokesCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ProfileProfilingInvokesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
